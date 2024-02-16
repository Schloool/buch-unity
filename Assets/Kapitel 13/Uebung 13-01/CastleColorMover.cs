using UnityEngine;

public class CastleColorMover : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        Vector3 targetPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0f;
        transform.position = targetPosition;
    }
}
