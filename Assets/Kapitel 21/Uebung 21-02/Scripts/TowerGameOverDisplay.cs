using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerGameOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private TowerPlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = FindObjectOfType<TowerPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    private void HandleHealthUpdate(float health)
    {
        if (health <= 0f)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}