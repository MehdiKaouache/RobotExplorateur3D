using UnityEngine;
public class GestionnaireJeu3D : MonoBehaviour
{
    [SerializeField] private int objectifBatteries = 3;
    [SerializeField] private PorteSortie3D porte;
    public int BatteriesCollectees { get; private set; }
    public void AjouterBatterie()
    {
        BatteriesCollectees++;
        Debug.Log($"Batteries : {BatteriesCollectees}/{objectifBatteries}");
        if (BatteriesCollectees >= objectifBatteries && porte != null) porte.Ouvrir();
    }
}
