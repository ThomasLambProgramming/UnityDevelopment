using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BezierCurve))]
public class BezierInspector : Editor
{
    private BezierCurve curve;
    private Transform handleTransform;
    private Quaternion handleRotation;


    [SerializeField] private float DirectionScale = 0.5f;
    [SerializeField] private int LineSteps = 10;
    private void OnSceneGUI() {
        curve = target as BezierCurve;
        handleTransform = curve.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ? 
            handleTransform.rotation : Quaternion.identity;

        Vector3 p0 = ShowPoint(0);
        Vector3 p1 = ShowPoint(1);
        Vector3 p2 = ShowPoint(2);
        Vector3 p3 = ShowPoint(3);

        Handles.color = Color.grey;
        Handles.DrawLine(p0, p1);
        Handles.DrawLine(p1, p2);
        Handles.DrawLine(p2, p3);

        ShowDirections();
        Handles.DrawBezier(p0, p3, p1, p2, Color.white, null, 2f);
    }
    private void ShowDirections()
    {
        Handles.color = Color.green;
        Vector3 lineStart = curve.GetPoint(0f);
        Handles.DrawLine(lineStart, lineStart + curve.GetDirection(0f) * DirectionScale);

        for (int i = 1; i <= LineSteps; i++)
        {
            float lineStepsDiff = i / (float)LineSteps;
            Vector3 lineEnd = curve.GetPoint(lineStepsDiff);

            Handles.DrawLine(lineEnd, lineEnd + curve.GetDirection(lineStepsDiff) * DirectionScale);
        }
    }
    private Vector3 ShowPoint(int a_index)
    {
        //Regardless it gets the world position of the offset from the main objects
        Vector3 point = handleTransform.TransformPoint(curve.points[a_index]);


        //if it changes update the point on the bezier curve and set it back to local position + save
        EditorGUI.BeginChangeCheck();
        point = Handles.DoPositionHandle(point, handleRotation);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(curve, "Move Point");
            EditorUtility.SetDirty(curve);
            curve.points[a_index] = handleTransform.InverseTransformPoint(point);
        }

        return point;
    }
}
