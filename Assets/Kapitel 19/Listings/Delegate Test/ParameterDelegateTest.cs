using UnityEngine;

public class ParameterDelegateTest : MonoBehaviour
{
    public delegate string TestDelegate(int number);

    private void Start()
    {
        TestDelegate testDelegate = NumberToText;
        testDelegate(10);
    }

    private string NumberToText(int x)
    {
        return $"Die Zahl ist {x}";
    }
}