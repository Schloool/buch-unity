using UnityEngine;

public class ActivationEventTest : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Script aktiv!");
    }

    private void OnDisable()
    {
        Debug.Log("Script inaktiv!");
    }
}