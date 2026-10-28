using UnityEngine;
public class PorteSortie3D : MonoBehaviour
{
    [SerializeField] private Transform battant;
    [SerializeField] private Vector3 decalageOuverture = new Vector3(0f, 3f, 0f);
    [SerializeField] private float vitesse = 2f;
    private Vector3 positionFermee, positionOuverte;
    private bool ouverte;
    private void Start()
    {
        if (battant == null) return;
        positionFermee = battant.localPosition;
        positionOuverte = positionFermee + decalageOuverture;
    }
    private void Update()
    {
        if (battant == null) return;
        Vector3 cible = ouverte ? positionOuverte : positionFermee;
        battant.localPosition = Vector3.MoveTowards(battant.localPosition, cible, vitesse * Time.deltaTime);
    }
    public void Ouvrir() => ouverte = true;
}
