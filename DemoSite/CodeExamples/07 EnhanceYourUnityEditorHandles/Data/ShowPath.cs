using System.Collections.Generic;
using UnityEngine;

public class ShowPath : MonoBehaviour
{
    public bool EditPath = false;
    public List<Vector3> Nodes = new List<Vector3>();

    public void OnDrawGizmosSelected()
    {
        if (EditPath)
            return;

        Vector3 posLast = new Vector3();
        bool second = false;

        for (int i = 0; i < Nodes.Count; i++)
        {
            if (second)
            {
                Gizmos.DrawLine(Nodes[i], posLast);
            }
            posLast = Nodes[i];
            second = true;
        }
    }
}