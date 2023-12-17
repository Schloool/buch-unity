using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformGoalDisplay : MonoBehaviour
{
    [SerializeField] private GameObject goalPanel;

    private PlatformGoal goal;
    
    private void Awake()
    {
        goal = FindObjectOfType<PlatformGoal>();
        goal.OnReachGoal += HandleReachGoal;
    }

    private void OnDestroy()
    {
        goal.OnReachGoal -= HandleReachGoal;
    }

    private void HandleReachGoal()
    {
        goalPanel.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}