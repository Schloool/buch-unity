using UnityEngine;
using UnityEngine.UI;

public class ShooterTimerDisplay : MonoBehaviour
{
    private Image timerImage;
    private ShooterTimer timer;
    
    private void Start()
    {
        timerImage = GetComponent<Image>();
        timer = FindObjectOfType<ShooterTimer>();
        timer.OnChangeTime += HandleChangeTime;
    }

    private void HandleChangeTime(float time)
    {
        timerImage.fillAmount = time / timer.StartTime;
    }
}