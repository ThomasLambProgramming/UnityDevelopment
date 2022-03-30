using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityEditor;
using System;

/// <summary>
/// THIS SCRIPT IS A REFLECTION TEST!
/// </summary>


[CustomEditor(typeof(Agent))]
public class AgentInspector : Editor
{
    //private void OnSceneGUI()
    //{
    //  Runs this function on the scene view    
    //}

    public override void OnInspectorGUI()
    {

        Type classType = typeof(Agent);

        foreach (var type in classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
        {
            if (type.FieldType == typeof(float))
            {
            }
        }



        //Run base inspector for the script
        //base.OnInspectorGUI();
    }
}
