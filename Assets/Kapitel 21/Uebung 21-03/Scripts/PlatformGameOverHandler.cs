using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformGameOverHandler : MonoBehaviour
{
    private PlatformPlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlatformPlayerHealth>();
        playerHealth.OnDeath += HandlePlayerDeath;
    }

    private void OnDestroy()
    {
        playerHealth.OnDeath -= HandlePlayerDeath;
    }

    private void HandlePlayerDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}