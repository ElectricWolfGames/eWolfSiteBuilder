using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShowLink : MonoBehaviour
{
    public GameObject Link;
    public bool Red = false;

    public void OnDrawGizmosSelected()
    {
        if (Red)
            Gizmos.color = Color.red;
        else
            Gizmos.color = Color.yellow;

        var pos = transform.position + Vector3.up * 2;
        

        Gizmos.DrawLine(transform.position, pos);

        if (Link == null)
        {
            Handles.Label(pos, $"{name} -> None");
            return;
        }

        Handles.Label(pos, $"{name} -> {Link.name}");
        Gizmos.DrawLine(transform.position, Link.transform.position);
    }
}
