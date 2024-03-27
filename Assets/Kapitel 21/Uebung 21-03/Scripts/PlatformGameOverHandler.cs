using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script für die Logik, die beim Tod des Spielers ausgelöst werden soll.
/// </summary>
public class PlatformGameOverHandler : MonoBehaviour
{
    private PlatformPlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<PlatformPlayerHealth>();
        playerHealth.OnDeath += HandlePlayerDeath;
    }

    private void OnDestroy()
    {
        playerHealth.OnDeath -= HandlePlayerDeath;
    }

    /// <summary>
    /// Behandelt den Tod des Spielers, indem das Spiel neustartet.
    ///
    /// Dafür wird die aktuelle Scene neu geladen.
    /// </summary>
    private void HandlePlayerDeath()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}