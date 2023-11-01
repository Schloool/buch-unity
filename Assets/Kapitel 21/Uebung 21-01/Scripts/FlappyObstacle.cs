using UnityEngine;

public class FlappyObstacle : MonoBehaviour
{
    public GameObject rockDown;
    
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