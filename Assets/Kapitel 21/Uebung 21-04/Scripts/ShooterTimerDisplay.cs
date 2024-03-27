using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Anzeigescript für die auf dem Timer verbleibende Zeit.
/// </summary>
public class ShooterTimerDisplay : MonoBehaviour
{
    private Image timerImage;
    private ShooterTimer timer;
    
    private void Awake()
    {
        timerImage = GetComponent<Image>();
        timer = FindObjectOfType<ShooterTimer>();
        timer.OnChangeTime += HandleChangeTime;
    }

    /// <summary>
    /// Behandelt Änderungen des Timers, indem mit dem verbleibenden Zeitanteil eine Farbleiste gefüllt wird.
    /// </summary>
    private void HandleChangeTime(float time)
    {
        timerImage.fillAmount = time / timer.StartTime;
    }
}