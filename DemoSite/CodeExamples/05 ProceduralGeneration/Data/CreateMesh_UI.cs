using UnityEditor;
using UnityEngine;

namespace eWolf.CodeExamples.ProceduralGeneration
{
    [CustomEditor(typeof(CreateMesh)), CanEditMultipleObjects]
    public class CreateMesh_UI : Editor
    {
        private CreateMesh _createMesh;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GUI.color = Color.green;
            if (GUILayout.Button("Build Mesh"))
            {
                _createMesh.BuildMesh();
            }

            if (GUILayout.Button("Clear Mesh"))
            {
                _createMesh.ClearMesh();
            }
        }

        private void OnEnable()
        {
            _createMesh = (CreateMesh)target;
        }
    }
}