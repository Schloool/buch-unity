using UnityEngine;

public class NumberComparison : MonoBehaviour
{
    private void CompareNumbers(int a, int b)
    {
        if (a > b)
        {
            Debug.Log("a ist größer als b.");
        } 
        else if (b > a)
        {
            Debug.Log("b ist größer als a.");
        }
        else
        {
            Debug.Log("a und b sind gleich groß.");
        }
    }

    private void CompareNumbersEarlyReturn(int a, int b)
    {
        if (a > b)
        {
            Debug.Log("a ist größer als b.");
            return;
        }

        if (b > a)
        {
            Debug.Log("b ist größer als a.");
            return;
        }
        
        Debug.Log("a und b sind gleich groß.");
    }

    private void CompareNumbersTernary(int a, int b)
    {
        string output = a > b ? 
            "a ist größer als b" : b > a ?
                "b ist größer als a" : "a und b sind gleich groß";
        Debug.Log(output);
    }
}