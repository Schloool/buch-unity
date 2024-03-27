using UnityEngine;

/// <summary>
/// Script für die Bewegungssteuerung des Spielers.
///
/// Dieses Script kümmert sich zur Vereinfachung außerdem um das Abspielen der passenden Lauf- und Sprunganimationen.
/// </summary>
public class PlatformPlayerMovement : MonoBehaviour
{
    private static readonly int movementHash = Animator.StringToHash("movementX");
    private static readonly int isJumpingHash = Animator.StringToHash("isJumping");
    
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private PlatformPlayerHealth playerHealth;
    private Rigidbody2D rigidbody;
    private Animator animator;
    private bool jump;
    private bool isInAir;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerHealth = GetComponent<PlatformPlayerHealth>();
        playerHealth.OnDeath += HandleDeath;
    }
    
    private void Update()
    {
        if (!isInAir && Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        float movementX = Input.GetAxisRaw("Horizontal") * speed;
        rigidbody.velocity = new Vector2(movementX * speed, rigidbody.velocity.y);
        
        if (jump)
        {
            jump = false;
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }

        isInAir = Mathf.Abs(rigidbody.velocity.y) > 0.01f;

        animator.SetFloat(movementHash, movementX);
        animator.SetBool(isJumpingHash, isInAir);
    }

    /// <summary>
    /// Behandelt den Tod des Spielers, indem der zugrundeliegende Rigidbody sowie diese Steuerung zerstört werden.
    /// </summary>
    private void HandleDeath()
    {
        playerHealth.OnDeath -= HandleDeath;
        Destroy(rigidbody);
        Destroy(this);
    }
}