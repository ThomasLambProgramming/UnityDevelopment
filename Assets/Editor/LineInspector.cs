using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//This overwrites the default editor/inspector instead of the default unity inspector
[CustomEditor(typeof(Line))]
public class LineInspector : Editor
{
    private void OnSceneGUI()
    {
        //Editor class has a target variable which is set to the object to be drawn when onscenegui is called
        //Since we know it will overwrite as the custom editor for the line we will have a target line.
        Line line = target as Line;

        Transform handleTransform = line.transform;

        //This is the transforms rotation, I think the Tools.pivotRotation is a global unity setting if its true then we
        //want to see where the handles are facing otherwise have them be a default (kinda cool)
        Quaternion handleRotation = Tools.pivotRotation == 
            PivotRotation.Local ? handleTransform.rotation : Quaternion.identity;

        //We want the handles to be converted from local space (offset from position) to world space to be displayed correctly
        Vector3 p0 = handleTransform.TransformPoint(line.p0);
        Vector3 p1 = handleTransform.TransformPoint(line.p1);

        Handles.color = Color.white;

        //Seems like it checks to see if any editor value changes, draws the handles for each point, then if they did change 
        //get the world position of the point (because it could be dragged) then convert back to the offset position (local position)
        //this runs whenever scene is on, it does the world conversion otherwise it will fuck up and change everything
        
        EditorGUI.BeginChangeCheck();
        p0 = Handles.DoPositionHandle(p0, handleRotation);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(line, "Move Point");
            EditorUtility.SetDirty(line);
            line.p0 = handleTransform.InverseTransformPoint(p0);
        }

        EditorGUI.BeginChangeCheck();
        p1 = Handles.DoPositionHandle(p1, handleRotation);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(line, "Move Point");
            EditorUtility.SetDirty(line);
            line.p1 = handleTransform.InverseTransformPoint(p1);
        }
        
        Handles.DrawLine(p0, p1);
    }
}
