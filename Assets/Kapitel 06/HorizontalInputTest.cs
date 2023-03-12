using UnityEngine;

public class HorizontalInputTest: MonoBehaviour
{
    private void Update()
    {
        float currentInput = Input.GetAxis("Horizontal");
        Debug.Log(currentInput);
    }
}