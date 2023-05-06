using UnityEngine;

public class HardWall : MonoBehaviour
{
    public float burstForce;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > burstForce)
        {
            Destroy(collision.gameObject);
        }
    }
}