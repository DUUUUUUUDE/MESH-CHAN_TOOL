using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpawnSphereWindow : EditorWindow
{

    string SphereName = "SphereChan";

    Vector3 Pos;

    PrimitiveType type;


    [MenuItem ("Window/SuperChan")]
    public static void ShowWindow ()
    {
        GetWindow<SpawnSphereWindow>("SuperChan");
    }

    private void OnGUI()
    {
        EditorGUILayout.Space();
        type = (PrimitiveType)EditorGUILayout.EnumFlagsField("Mesh",type);
        EditorGUILayout.Space ();
        Pos = EditorGUILayout.Vector3Field("SphereChan Pos", Pos);
        EditorGUILayout.Space();

        if (GUILayout.Button ("CREATE " + type + "-CHAN !!"))
        {
            GameObject sphere = GameObject.CreatePrimitive(type);
            sphere.transform.position = Pos;
        }

    }

}
