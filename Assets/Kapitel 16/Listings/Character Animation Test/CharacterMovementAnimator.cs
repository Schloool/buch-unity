using UnityEngine;

public class CharacterMovementAnimator : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    
    private Rigidbody rigidbody;
    private Animator animator;
    private bool jump;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 newVelocity = moveInput * speed;
        newVelocity.y = rigidbody.velocity.y;
        rigidbody.velocity = newVelocity;

        if (moveInput.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(moveInput);
        }

        if (jump)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
        
        animator.SetFloat("moveXZ", moveInput.magnitude);
        animator.SetFloat("moveY", Mathf.Abs(rigidbody.velocity.y));
    }
}
