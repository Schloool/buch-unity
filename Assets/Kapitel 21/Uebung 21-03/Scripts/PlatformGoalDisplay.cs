using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script für die Logik, die beim Erreichen des Zielbereichs ausgelöst werden soll.
/// </summary>
public class PlatformGoalDisplay : MonoBehaviour
{
    [SerializeField] private GameObject goalPanel;
    [SerializeField] private PlatformGoal goal;
    
    private void Awake()
    {
        goal.OnReachGoal += HandleReachGoal;
    }

    private void OnDestroy()
    {
        goal.OnReachGoal -= HandleReachGoal;
    }

    /// <summary>
    /// Behandelt das Erreichen des Ziels, indem das UI für das Spielende angezeigt wird.
    /// </summary>
    private void HandleReachGoal()
    {
        goalPanel.SetActive(true);
    }

    /// <summary>
    /// Startet das Spiel neu, indem die aktuelle Scene neu gestartet wird.
    /// </summary>
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}