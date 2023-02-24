using UnityEngine;

public class BigNumberArray : MonoBehaviour
{
    private void Start()
    {
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 200;
        }

        for (int i = 0; i < numbers.Length; i += 2)
        {
            Debug.Log(numbers[i]);
        }
    }
}