using UnityEngine;

public class PositionSetter : MonoBehaviour
{
    private void Start()
    {
        Vector3 startPosition = new Vector3(2f, 3f, 4f);
        transform.position = startPosition;
    }
}