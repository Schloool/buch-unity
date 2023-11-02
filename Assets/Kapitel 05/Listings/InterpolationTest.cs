using UnityEngine;

public class InterpolationTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Mathf.Lerp(0, 10, 0.5f));
        Debug.Log(Mathf.Lerp(32, 64, 0.38f));
    }
}