using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShowPath))]
[CanEditMultipleObjects]
public class ShowPath_UI : Editor
{
    private ShowPath _node;

    public void OnEnable()
    {
        _node = target.GetComponent<ShowPath>();
    }

    public void OnSceneGUI()
    {
        if (!_node.EditPath)
            return;

        Vector3 handlePosition = new Vector3(1, 0, 0);

        for (int i = 0; i < _node.Nodes.Count; i++)
        {
            handlePosition = _node.Nodes[i];

            Vector3 newpos = Handles.FreeMoveHandle(
               handlePosition,
               Quaternion.identity, 0.5f, Vector3.zero, Handles.RectangleHandleCap);

            if (newpos != handlePosition)
            {
                newpos.y = 0;
                _node.Nodes[i] = newpos;
            }
        }

        handlePosition.x += 2f;
        Quaternion q = Quaternion.Euler(90, 0, 0);
        if (Handles.Button(handlePosition, q, 0.5f, 0.5f, Handles.CircleHandleCap))
        {
            _node.Nodes.Add(handlePosition);
        }

    }
}