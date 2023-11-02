using UnityEngine;

public class PrecisionTest : MonoBehaviour
{
    private void Start()
    {
        float a = 1 / 3f;
        Debug.Log(a);

        double b = 1 / 3d;
        Debug.Log(b);

        decimal c = 1 / 3m;
        Debug.Log(c);
    }
}