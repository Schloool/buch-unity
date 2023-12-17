using UnityEngine;

public class PlatformPlayerMovement : MonoBehaviour
{
    private static readonly int MovementHash = Animator.StringToHash("movementX");
    private static readonly int IsJumpingHash = Animator.StringToHash("isJumping");
    
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private PlatformPlayerHealth playerHealth;
    private Rigidbody2D rigidbody;
    private Animator animator;
    private bool isJumping;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerHealth = GetComponent<PlatformPlayerHealth>();
        playerHealth.OnDeath += HandleDeath;
    }

    private void HandleDeath()
    {
        playerHealth.OnDeath -= HandleDeath;
        Destroy(rigidbody);
        Destroy(this);
    }

    private void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * movementX * speed * Time.deltaTime;

        if (!isJumping && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
        
        animator.SetFloat(MovementHash, movementX);
    }

    private void FixedUpdate()
    {
        isJumping = Mathf.Abs(rigidbody.velocity.y) > 0.05f;
        animator.SetBool(IsJumpingHash, isJumping);
    }
}