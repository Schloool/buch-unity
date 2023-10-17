using UnityEngine;

public class JumpAndRunCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform);
    }
}