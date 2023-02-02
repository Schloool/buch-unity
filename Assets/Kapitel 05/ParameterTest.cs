using UnityEngine;

public class ParameterTest : MonoBehaviour
{
    void Start()
    {
        AddNumbers(5, 10);
    }

    void AddNumbers(int x, int y)
    {
        Debug.Log(x + y);
    }
}