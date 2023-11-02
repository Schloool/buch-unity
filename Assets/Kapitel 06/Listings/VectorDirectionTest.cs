using UnityEngine;

public class VectorDirectionTest : MonoBehaviour
{
    private void Start()
    {
        Vector3 point1 = new Vector3(1f, 1f, 1f);
        Vector3 point2 = new Vector3(2f, 3f, 2f);

        Vector3 direction = point2 - point1;
        
        Debug.Log(direction);
        Debug.Log(direction.magnitude);
        Debug.Log(direction.normalized);
        Debug.Log(direction.normalized.magnitude);
    }
}