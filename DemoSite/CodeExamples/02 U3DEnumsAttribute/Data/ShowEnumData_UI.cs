using eWolf.CodeExamples.EnumnAttributes;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShowEnumData)), CanEditMultipleObjects]
public class ShowEnumData_UI : Editor
{
    private ShowEnumData _showEnumData;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GUI.color = Color.green;
        if (GUILayout.Button("Show Attribute Data"))
        {
            _showEnumData.ShowAttributeData();
        }
    }

    private void OnEnable()
    {
        _showEnumData = (ShowEnumData)target;
    }
}