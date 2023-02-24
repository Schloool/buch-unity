using UnityEngine;

public class CountBackwards : MonoBehaviour
{
    private void Start()
    {
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }
}