using UnityEngine;

public class MobileInputTest : MonoBehaviour
{
    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Ended ||
                touch.phase == TouchPhase.Canceled) continue;
            
            Debug.Log($"Berührung von Finger {touch.fingerId}");
        }
    }
}