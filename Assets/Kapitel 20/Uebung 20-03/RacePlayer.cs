using UnityEngine;

public class RacePlayer : MonoBehaviour
{
    [SerializeField] private float speed;

    private RaceCountdown countdown;
    private Rigidbody rigidbody;
    private bool canMove;
    
    private void Awake()
    {
        countdown = FindObjectOfType<RaceCountdown>();
        countdown.OnChangeTimer += HandleCountdownUpdate;

        rigidbody = GetComponent<Rigidbody>();
        canMove = false;
    }

    private void FixedUpdate()
    {
        if (!canMove) return;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rigidbody.MovePosition(transform.position + move * speed * Time.fixedDeltaTime);
    }

    private void HandleCountdownUpdate(int time)
    {
        if (time == 0)
        {
            canMove = true;
            countdown.OnChangeTimer -= HandleCountdownUpdate;
        }
    }
}