using UnityEngine;

public class MouseButtonInputCheck : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Linke Maustaste geklickt!");
        }
    }
}