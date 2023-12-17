using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyGameOverDisplay : MonoBehaviour
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

    private void HandlePlaneDeath()
    {
        pointHandler.OverwriteHighscore();
        
        panelObject.SetActive(true);
        scoreText.text = pointHandler.Points.ToString();
        highscoreText.text = pointHandler.GetHighscore().ToString();

        planeMovement.OnDeath -= HandlePlaneDeath;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}