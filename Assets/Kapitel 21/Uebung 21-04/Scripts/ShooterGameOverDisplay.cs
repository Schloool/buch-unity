using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Anzeigescript für das Ende des Spiels.
/// </summary>
public class ShooterGameOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text pointsText;

    private ShooterPointCounter pointCounter;
    private ShooterTimer timer;

    private void Awake()
    {
        pointCounter = FindObjectOfType<ShooterPointCounter>();
        timer = FindObjectOfType<ShooterTimer>();
        timer.OnTimerEnd += HandleTimerEnd;
    }

    private void OnDestroy()
    {
        timer.OnTimerEnd -= HandleTimerEnd;
    }

    /// <summary>
    /// Behandelt das Ende des Timers, da dieser Moment als Ende des Spiels gilt.
    /// </summary>
    private void HandleTimerEnd()
    {
        gameOverPanel.SetActive(true);
        pointsText.text = pointCounter.CurrentPoints.ToString();
    }

    /// <summary>
    /// Startet das Spiel neu, indem die aktuelle Scene neu geladen wird.
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}