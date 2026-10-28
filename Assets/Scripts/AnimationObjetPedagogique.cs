using UnityEngine;
public class AnimationObjetPedagogique : MonoBehaviour
{
    [SerializeField] private float vitesseRotation = 45f;
    [SerializeField] private float amplitudeFlottement = 0.15f;
    [SerializeField] private float vitesseFlottement = 2f;
    private Vector3 positionInitiale;
    private void Start() { positionInitiale = transform.position; }
    private void Update()
    {
        transform.Rotate(Vector3.up, vitesseRotation * Time.deltaTime, Space.World);
        float y = Mathf.Sin(Time.time * vitesseFlottement) * amplitudeFlottement;
        transform.position = positionInitiale + Vector3.up * y;
    }
}
