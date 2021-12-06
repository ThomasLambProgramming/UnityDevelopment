using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Line))]
public class LineInspector : Editor
{
    private void OnSceneGUI()
    {
        Line line = target as Line;

        Transform handleTransform = line.transform;

        //is the tools pivot rotation local if true then give handletransform otherwise give default
        Quaternion handleRotation = Tools.pivotRotation == PivotRotation.Local ? handleTransform.rotation : Quaternion.identity;

        Vector3 p0 = handleTransform.TransformPoint(line.p0);
        Vector3 p1 = handleTransform.TransformPoint(line.p1);

        Handles.color = Color.white;
        Handles.DrawLine(p0, p1);
        Handles.DoPositionHandle(p0, handleRotation);
        Handles.DoPositionHandle(p1, handleRotation);

    }
}
