using UnityEngine;

public class CharacterMovementAnimator : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    
    private Rigidbody rigidbody;
    private Animator animator;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.Translate(movement * Time.deltaTime * speed, Space.World);
        animator.SetFloat("moveXZ", movement.magnitude);

        if (movement.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        animator.SetFloat("moveY", Mathf.Abs(rigidbody.velocity.y));
    }
}
