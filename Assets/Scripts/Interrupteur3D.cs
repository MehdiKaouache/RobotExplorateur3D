using UnityEngine;
public class Interrupteur3D : MonoBehaviour
{
    [SerializeField] private PorteSortie3D porte;
    private bool joueurProche;
    private void Update()
    {
        if (joueurProche && Input.GetKeyDown(KeyCode.E) && porte != null) porte.Ouvrir();
    }
    private void OnTriggerEnter(Collider a) { if (a.CompareTag("Player")) joueurProche = true; }
    private void OnTriggerExit(Collider a) { if (a.CompareTag("Player")) joueurProche = false; }
}
