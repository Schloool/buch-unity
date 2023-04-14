using UnityEngine;

public class VelocityChecker : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void FixedUpdate()
    {
        if (rigidbody.velocity.x > 5f)
        {
            Debug.Log("Die X-Velocity ist größer als 5");
        }
    }
}
