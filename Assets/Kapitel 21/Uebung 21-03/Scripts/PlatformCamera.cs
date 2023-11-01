using UnityEngine;

public class PlatformCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float xOffset;

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + xOffset, transform.position.y, transform.position.z);
    }
}