using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShooterGameOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text pointsText;

    private ShooterPointCounter pointCounter;
    private ShooterTimer timer;

    private void Start()
    {
        pointCounter = FindObjectOfType<ShooterPointCounter>();
        timer = FindObjectOfType<ShooterTimer>();
        timer.OnTimerEnd += HandleTimerEnd;
    }

    private void OnDestroy()
    {
        timer.OnTimerEnd -= HandleTimerEnd;
    }

    private void HandleTimerEnd()
    {
        gameOverPanel.SetActive(true);
        pointsText.text = pointCounter.CurrentPoints.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}