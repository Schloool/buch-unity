using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Dieses Script ist für die Verwaltung der Logik verantwortlich, die beim Spielende abgespielt wird.
/// Dazu gehört neben der Anzeige passender UI-Elemente auch das Setzen der Timescale sowie das Neuladen der
/// Scene, wenn der passende Button gedrückt wird.
/// </summary>
public class FlappyGameOverHandler : MonoBehaviour
{
    [SerializeField] private GameObject panelObject;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highscoreText;

    private FlappyPlaneMovement planeMovement;
    private FlappyPointHandler pointHandler;
    
    private void Awake()
    {
        planeMovement = FindObjectOfType<FlappyPlaneMovement>();
        pointHandler = FindObjectOfType<FlappyPointHandler>();
        planeMovement.OnDeath += HandlePlaneDeath;
    }

    private void OnDestroy()
    {
        planeMovement.OnDeath -= HandlePlaneDeath;
    }

    private void HandlePlaneDeath()
    {
        pointHandler.OverwriteHighscore();
        
        panelObject.SetActive(true);
        scoreText.text = pointHandler.Points.ToString();
        highscoreText.text = pointHandler.GetHighscore().ToString();
        Time.timeScale = 0f;

        planeMovement.OnDeath -= HandlePlaneDeath;
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}