using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(cube))]
public class CubeEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cube Cube = (cube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate Color"))
        {
            Cube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {
            Cube.Reset();
        }

        GUILayout.EndHorizontal();
    }



}
