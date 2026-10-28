using UnityEngine;

public class VentArbreSimple : MonoBehaviour
{
    [SerializeField] private Transform couronne;
    [SerializeField] private float force = 2f;
    [SerializeField] private float vitesse = 1.5f;
    [SerializeField] private float decalageAleatoire = 2f;

    private Quaternion rotationInitiale;
    private float decalage;

    private void Start()
    {
        if (couronne == null) return;
        rotationInitiale = couronne.localRotation;
        decalage = Random.Range(0f, decalageAleatoire);
    }

    private void Update()
    {
        if (couronne == null) return;
        float angle = Mathf.Sin((Time.time + decalage) * vitesse) * force;
        couronne.localRotation = rotationInitiale * Quaternion.Euler(0f, 0f, angle);
    }
}
