using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Capsule))]
public class CapsuleEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Capsule capsule = (Capsule)target;

        GUILayout.BeginHorizontal();
        GUILayout.Label("Changes Objects rotation randomly");
        GUILayout.Label("Changes objects size randomly");
        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();


        if (GUILayout.Button("Spin"))
        {
            capsule.Spin();
        }

        

        if (GUILayout.Button("Change Size"))
        {
            capsule.sizeChange();
        }

        GUILayout.EndHorizontal();
    }



}
