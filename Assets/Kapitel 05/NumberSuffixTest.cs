using UnityEngine;

public class NumberSuffixTest : MonoBehaviour
{
    private void Start()
    {
        TestMethod(100);
        TestMethod(100L);
    }

    private void TestMethod(int i)
    {
        Debug.Log("Aufruf mit int");
    }

    private void TestMethod(long l)
    {
        Debug.Log("Aufruf mit long");
    }
}