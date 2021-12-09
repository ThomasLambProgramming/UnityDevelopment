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


    [SerializeField] private float DirectionScale = 0.5f;
    [SerializeField] private int LineSteps = 10;
    private int stepsPerCurve = 10;
    private void OnSceneGUI() {
        spline = target as BezierSpline;
        handleTransform = spline.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ? 
            handleTransform.rotation : Quaternion.identity;


        Vector3 p0 = ShowPoint(0);
        
        for (int i = 1; i < spline.points.Length; i += 3)
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
        DrawDefaultInspector();
        spline = target as BezierSpline;
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
    private Vector3 ShowPoint(int a_index)
    {
        //Regardless it gets the world position of the offset from the main objects
        Vector3 point = handleTransform.TransformPoint(spline.points[a_index]);


        //if it changes update the point on the bezier curve and set it back to local position + save
        EditorGUI.BeginChangeCheck();
        point = Handles.DoPositionHandle(point, handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(spline, "Move Point");
            EditorUtility.SetDirty(spline);
            spline.points[a_index] = handleTransform.InverseTransformPoint(point);
        }

        return point;
    }
}