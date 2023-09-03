using UnityEngine;

public class CalcDelegateExample : MonoBehaviour
{
    public delegate int NumberDelegate(int a, int b);

    private void Start()
    {
        NumberDelegate testDelegate = AddNumbers;
        Debug.Log(testDelegate(5, 5));

        testDelegate = SubtractNumbers;
        Debug.Log(testDelegate(5, 5));
        
        UseDelegate(AddNumbers);
        UseDelegate(SubtractNumbers);
    }

    private void UseDelegate(NumberDelegate numberDelegate)
    {
        Debug.Log(numberDelegate(10, 5));
    }

    private int AddNumbers(int a, int b)
    {
        return a + b;
    }

    private int SubtractNumbers(int a, int b)
    {
        return a - b;
    }
}