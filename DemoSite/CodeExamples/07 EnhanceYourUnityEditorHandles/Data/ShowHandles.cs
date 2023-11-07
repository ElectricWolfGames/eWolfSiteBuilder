using UnityEngine;

public class ShowHandles : MonoBehaviour
{
    public float Size = 1;
    public Vector3 GatePos { get; set; } = new Vector3(1, 0, 0);

    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Size);
    }
}