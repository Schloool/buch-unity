using UnityEngine;

public class TimeScaleTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0f;
        }
    }
}