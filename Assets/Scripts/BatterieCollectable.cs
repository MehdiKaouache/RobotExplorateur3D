using UnityEngine;
public class BatterieCollectable : MonoBehaviour
{
    private GestionnaireJeu3D gestionnaire;
    private bool collectee;
    private void Awake() { gestionnaire = FindFirstObjectByType<GestionnaireJeu3D>(); }
    private void OnTriggerEnter(Collider autre)
    {
        if (collectee || !autre.CompareTag("Player") || gestionnaire == null) return;
        collectee = true;
        gestionnaire.AjouterBatterie();
        Destroy(gameObject);
    }
}
