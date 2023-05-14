using UnityEngine;

public class VectorNormalizeTest : MonoBehaviour
{
    private void Start()
    {
        Vector3 highVector = new Vector3(0f, 100f, 0f);

        Debug.Log(highVector.normalized);
        
        Debug.Log(highVector.magnitude);
        Debug.Log(highVector.normalized.magnitude);
    }
}