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


    private const int LineSteps = 50;
    private void OnSceneGUI() {
        curve = target as BezierCurve;
        handleTransform = curve.transform;
        handleRotation = Tools.pivotRotation == PivotRotation.Local ? 
            handleTransform.rotation : Quaternion.identity;

        Vector3 p0 = ShowPoint(0);
        Vector3 p1 = ShowPoint(1);
        Vector3 p2 = ShowPoint(2);

        Handles.color = Color.grey;
        Handles.DrawLine(p0, p1);
        Handles.DrawLine(p1, p2);

        Handles.color = Color.white;
        Vector3 lineStart = curve.GetPoint(0f);

        for (int i = 1; i <= LineSteps; i++)
        {
            Vector3 lineEnd = curve.GetPoint(i / (float)LineSteps);
            Handles.DrawLine(lineStart, lineEnd);
            lineStart = lineEnd;
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
