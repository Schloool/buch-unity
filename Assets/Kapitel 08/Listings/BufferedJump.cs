using UnityEngine;

public class BufferedJump : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    private bool jump;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (jump)
        {
            playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x, 10f, playerRigidbody.velocity.z);
            jump = false;
        }
    }
}