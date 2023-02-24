using UnityEngine;

public class ApproximationTest : MonoBehaviour
{
    private void Start()
    {
        float a = 1 / 3f;
        double b = 1 / 3d;

        Debug.Log(a == b);
        Debug.Log(Mathf.Approximately(a, (float) b));
    }
}