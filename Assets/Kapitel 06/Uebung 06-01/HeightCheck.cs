using UnityEngine;

public class HeightCheck : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y > 10f)
        {
            Debug.Log("Zu weit oben!");
        }
    }
}
