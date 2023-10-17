using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    public GameObject[] balloons;

    private int balloonIndex = 0;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;

        if (balloonIndex >= balloons.Length)
        {
            Debug.Log("Es sind bereits alle Ballons geplatzt!");
            return;
        }
        
        Destroy(balloons[balloonIndex++]);
    }
}
