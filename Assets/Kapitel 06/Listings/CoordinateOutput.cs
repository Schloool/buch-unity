using UnityEngine;

public class CoordinateOutput : MonoBehaviour
{
    private void Start()
    {
        Vector3 position = transform.position;
        float x = position.x;
        Debug.Log($"X-Koordinate: {x}");
    }
}