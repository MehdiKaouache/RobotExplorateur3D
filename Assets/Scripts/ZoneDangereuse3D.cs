using UnityEngine;
public class ZoneDangereuse3D : MonoBehaviour
{
    [SerializeField] private Transform pointReapparition;
    private void OnTriggerEnter(Collider autre)
    {
        if (!autre.CompareTag("Player") || pointReapparition == null) return;
        Rigidbody rb = autre.attachedRigidbody;
        if (rb == null) return;
        rb.position = pointReapparition.position;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
