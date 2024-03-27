using UnityEngine;

/// <summary>
/// Script für ein Hindernis, das sich während des Spiels auf das Flugzeug zubewegt und beim Überschreiten einer
/// bestimmten Position automatisch selbst zerstört.
/// </summary>
public class FlappyObstacle : MonoBehaviour
{
    public GameObject RockDown => rockDown;

    [SerializeField] private GameObject rockDown;
    [SerializeField] private float speed;
    [SerializeField] private float destroyCoordinate;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= destroyCoordinate)
        {
            Destroy(gameObject);
        }
    }
}