using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShowPath : MonoBehaviour
{
    public bool EditPath = true;
    public List<Vector3> Nodes = new List<Vector3>();

    public void OnDrawGizmosSelected()
    {
        if (!EditPath)
            return;

        if (!Nodes.Any())
            return;

        Vector3 posLast = Nodes[0];
        
        for (int i = 1; i < Nodes.Count; i++)
        {
            Gizmos.DrawLine(Nodes[i], posLast);
            posLast = Nodes[i];
        }
    }
}