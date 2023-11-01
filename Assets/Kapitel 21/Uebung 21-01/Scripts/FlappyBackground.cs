using UnityEngine;

public class FlappyBackground : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private float resetCoordinate;

    private void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        if (transform.position.x <= -resetCoordinate)
        {
            transform.position = new Vector3(resetCoordinate, transform.position.y);
        }
    }
}