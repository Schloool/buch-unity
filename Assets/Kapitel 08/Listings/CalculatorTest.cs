using UnityEngine;

public class CalculatorTest : MonoBehaviour
{
    private void Start()
    {
        int result = Calculator.AddNumbers("5 + 5");
        Debug.Log(result);
    }
}