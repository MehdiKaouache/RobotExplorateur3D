using UnityEngine;
public class CameraSuiveuse3D : MonoBehaviour
{
    [SerializeField] private Transform cible;
    [SerializeField] private Vector3 decalage = new Vector3(0f, 8f, -10f);
    [SerializeField] private float fluidite = 6f;
    public void DefinirCible(Transform nouvelleCible) { cible = nouvelleCible; }
    private void LateUpdate()
    {
        if (cible == null) return;
        Vector3 pos = cible.position + decalage;
        transform.position = Vector3.Lerp(transform.position, pos, fluidite * Time.deltaTime);
        transform.LookAt(cible.position + Vector3.up);
    }
}
