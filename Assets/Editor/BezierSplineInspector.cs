using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BezierSpline))]
public class BezierSplineInspector : Editor
{
    private BezierSpline spline;
    private Transform handleTransform;
    private Quaternion handleRotation;


    private const float DirectionScale = 0.5f;
    private const int LineSteps = 10;
    private const int stepsPerCurve = 10;

    private void OnSceneGUI() {
        spline = target as BezierSpline;
        handleTransform = spline.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ? 
            handleTransform.rotation : Quaternion.identity;


        Vector3 p0 = ShowPoint(0);
        
        for (int i = 1; i < spline.ControlPointCount; i += 3)
        {
            Vector3 p1 = ShowPoint(i);
            Vector3 p2 = ShowPoint(i + 1);
            Vector3 p3 = ShowPoint(i + 2);

            Handles.color = Color.grey;
            Handles.DrawLine(p0, p1);
            Handles.DrawLine(p1, p2);
            Handles.DrawLine(p2, p3);

            Handles.DrawBezier(p0, p3, p1, p2, Color.white, null, 2f);
            p0 = p3;
        }
        ShowDirections();
    }
    public override void OnInspectorGUI()
    {
        spline = target as BezierSpline;
        if (selectedIndex >= 0 && selectedIndex < spline.ControlPointCount)
        {
            DrawSelectedPointInspector();
        }
        if (GUILayout.Button("Add Curve"))
        {
            Undo.RecordObject(spline, "Add Curve");
            spline.AddCurve();
            EditorUtility.SetDirty(spline);
        }
    }
    private void ShowDirections()
    {
        Handles.color = Color.green;
        Vector3 lineStart = spline.GetPoint(0f);
        Handles.DrawLine(lineStart, lineStart + spline.GetDirection(0f) * DirectionScale);

        int steps = stepsPerCurve * spline.CurveCount();
        for (int i = 1; i <= steps; i++)
        {
            float lineStepsDiff = i / (float)steps;
            Vector3 lineEnd = spline.GetPoint(lineStepsDiff);

            Handles.DrawLine(lineEnd, lineEnd + spline.GetDirection(lineStepsDiff) * DirectionScale);
        }
    }
    private void DrawSelectedPointInspector()
    {
        GUILayout.Label("Selected Point");
        EditorGUI.BeginChangeCheck();
        Vector3 point = EditorGUILayout.Vector3Field("Position", spline.GetControlPoint(selectedIndex));
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(spline, "Move Point");
            EditorUtility.SetDirty(spline);
            spline.SetControlPoint(selectedIndex, point);
        }
        EditorGUI.BeginChangeCheck();

        //Make a layout option on the inspector that will cast back into the enum with the users selection
        BezierControlPointMode mode = (BezierControlPointMode)
            EditorGUILayout.EnumPopup("Mode", spline.GetControlPointMode(selectedIndex));

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(spline, "Change Point Mode");
            spline.SetControlPointMode(selectedIndex, mode);
            EditorUtility.SetDirty(spline);
        }
    }

    private const float handleSize = 0.1f;
    private const float pickSize = 0.1f;
    private int selectedIndex = -1;

    private static Color[] modeColors = {
        Color.white,
        Color.yellow,
        Color.cyan
    };

    private Vector3 ShowPoint(int a_index)
    {
        //Regardless it gets the world position of the offset from the main objects
        Vector3 point = handleTransform.TransformPoint(spline.GetControlPoint(a_index));
        float size = HandleUtility.GetHandleSize(point);

        Handles.color = modeColors[(int)spline.GetControlPointMode(a_index)];
        if (Handles.Button(point, handleRotation, size * handleSize, size * pickSize, Handles.DotHandleCap))
        {
            selectedIndex = a_index;
            Repaint();
        }

        if (selectedIndex == a_index)
        {
            //if it changes update the point on the bezier curve and set it back to local position + save
            EditorGUI.BeginChangeCheck();
            point = Handles.DoPositionHandle(point, handleRotation);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(spline, "Move Point");
                EditorUtility.SetDirty(spline);
                spline.SetControlPoint(a_index, handleTransform.InverseTransformPoint(point));
            }
        }

        return point;
    }
}