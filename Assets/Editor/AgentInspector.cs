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
    private bool _ranReflectionOnce = false;
    public override void OnInspectorGUI()
    {
        if (!_ranReflectionOnce)
        {
            Type classType = typeof(Agent);

            foreach (var type in classType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (type.FieldType == typeof(float))
                    type.SetValue(target, 123);
            }
            _ranReflectionOnce = true;
        }

        //Run base inspector for the script
        base.OnInspectorGUI();
    }
}
