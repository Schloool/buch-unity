using UnityEngine;

public class InfiniteTrampoline : MonoBehaviour
{
    public float trampolineForce;
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 force = Vector3.up * trampolineForce;
        collision.rigidbody.AddForce(force, ForceMode.VelocityChange);
    }
}
