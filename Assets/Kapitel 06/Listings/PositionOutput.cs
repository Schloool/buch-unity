using UnityEngine;

public class PositionOutput : MonoBehaviour
{
    private void Start()
    {
        Vector3 position = transform.position;
        Debug.Log(position);
    }
}
