using UnityEngine;

public class SimpleController : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        transform.position += direction * speed * Time.deltaTime;
    }
}