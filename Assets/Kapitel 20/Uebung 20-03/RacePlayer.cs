using UnityEngine;

public class RacePlayer : MonoBehaviour
{
    [SerializeField] private float speed;

    private RaceCountdown countdown;
    private RaceGoal raceGoal;
    private Rigidbody rigidbody;
    
    private void Awake()
    {
        countdown = FindObjectOfType<RaceCountdown>();
        raceGoal = FindObjectOfType<RaceGoal>();
        countdown.OnChangeTimer += HandleCountdownUpdate;
        raceGoal.OnEnd += HandleRaceEnd;
        
        rigidbody = GetComponent<Rigidbody>();
        enabled = false;
    }

    private void OnDestroy()
    {
        countdown.OnChangeTimer -= HandleCountdownUpdate;
        raceGoal.OnEnd -= HandleRaceEnd;
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rigidbody.velocity = move * speed;
    }

    private void HandleCountdownUpdate(int time)
    {
        if (time == 0)
        {
            enabled = true;
            countdown.OnChangeTimer -= HandleCountdownUpdate;
        }
    }
    
    private void HandleRaceEnd(bool playerWon)
    {
        rigidbody.velocity = Vector3.zero;
        enabled = false;
    }
}