using UnityEngine;

public class MarbleForceInput : MonoBehaviour
{
    [SerializeField] private float force;
    
    private Rigidbody2D rigidbody;
    private bool applyForce;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            applyForce = true;
        }
    }

    private void FixedUpdate()
    {
        if (applyForce)
        {
            rigidbody.AddForce(Vector2.right * force, ForceMode2D.Impulse);
            applyForce = false;
        }
    }
}
