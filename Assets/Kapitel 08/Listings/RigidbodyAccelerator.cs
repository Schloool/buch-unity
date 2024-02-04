using UnityEngine;

public class RigidbodyAccelerator : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * acceleration);
    }
}
