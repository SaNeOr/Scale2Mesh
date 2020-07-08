using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Scale2Mesh))]
public class Scale2MeshEditor : Editor
{
    bool isFirstMark = true;
    public override void OnInspectorGUI()
    {
        Scale2Mesh s2m = target as Scale2Mesh;
        DrawDefaultInspector();

        if(isFirstMark){
            s2m.MarkVerticesInfo();
            isFirstMark = false;
        }
        if (GUILayout.Button("Scale2MeshSize")){
            s2m.S2M();
        }
        if (GUILayout.Button("Change Mesh Size")){
            s2m.ChangeMeshSize();
        }


    }
}
