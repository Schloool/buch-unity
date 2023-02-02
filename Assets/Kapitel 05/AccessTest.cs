using UnityEngine;

public class AccessTest : MonoBehaviour
{
    public int myVariable = 42;

    private void Update()
    {
        Debug.Log(myVariable);
    }
}