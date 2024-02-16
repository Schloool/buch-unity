using UnityEngine;

public class CalculatorTest : MonoBehaviour
{
    private void Start()
    {
        int result = Calculator.AddAndDouble(2, 3);
        Debug.Log(result);
    }
}