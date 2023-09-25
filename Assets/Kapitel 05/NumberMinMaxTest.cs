using UnityEngine;

public class NumberMinMaxTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Mathf.Max(5, 10));
        Debug.Log(Mathf.Min(5, 10));
        
        Debug.Log(Mathf.Clamp(10, 1, 5));
        Debug.Log(Mathf.Clamp(-3, 1, 5));
        Debug.Log(Mathf.Clamp(4, 1, 5));
        
        Debug.Log(Mathf.Clamp01(-2f));
        Debug.Log(Mathf.Clamp01(3f));
        Debug.Log(Mathf.Clamp01(0.4f));
    }
}