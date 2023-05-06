using UnityEngine;

public class InfiniteTrampoline : MonoBehaviour
{
    public float trampolineForce;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody == null) return;
        
        Vector3 force = Vector3.up * trampolineForce;
        collision.rigidbody.AddForce(force, ForceMode.VelocityChange);
    }
}
