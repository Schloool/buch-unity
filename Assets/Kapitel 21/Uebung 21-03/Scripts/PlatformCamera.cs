using UnityEngine;

/// <summary>
/// Script, durch das die Kamera dem Spieler mit einem vorgegebenen Abstand folgt.
/// </summary>
public class PlatformCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float xOffset;

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + xOffset, transform.position.y, transform.position.z);
    }
}