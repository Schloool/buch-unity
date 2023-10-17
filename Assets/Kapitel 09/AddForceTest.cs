using UnityEngine;

public class AddForceTest : MonoBehaviour
{
  private Rigidbody rigidbody;

  private void Start()
  {
    rigidbody = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      rigidbody.AddForce(Vector3.forward * 5f, ForceMode.Impulse);
    }
  }
}