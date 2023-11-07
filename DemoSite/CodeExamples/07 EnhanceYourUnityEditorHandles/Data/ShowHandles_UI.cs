using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShowHandles))]
[CanEditMultipleObjects]
public class ShowHandles_UI : Editor
{
    private ShowHandles _node;

    public void OnEnable()
    {
        _node = target.GetComponent<ShowHandles>();
    }

    public void OnSceneGUI()
    {
        var handlePosition = _node.gameObject.transform.position + _node.GatePos;

        Vector3 newpos = Handles.FreeMoveHandle(
                handlePosition,
                Quaternion.identity, 0.5f, Vector3.zero, Handles.RectangleHandleCap);

        if (newpos != handlePosition)
        {
            _node.GatePos = newpos - _node.gameObject.transform.position;

            _node.Size = _node.GatePos.magnitude;
        }
    }
}