using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script für das Anzeigeelement, das beim Spielende auf dem Bildschirm erscheint.
/// </summary>
public class TowerGameOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private TowerPlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<TowerPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    /// <summary>
    /// Reagiert auf die Änderung der Lebenspunkte des Spielers.
    /// Fallen die Lebenspunkte auf 0 gilt das Spiel als verloren und das UI-Element soll erscheinen. 
    /// </summary>
    private void HandleHealthUpdate(float health)
    {
        if (health <= 0f)
        {
            gameOverPanel.SetActive(true);
        }
    }

    /// <summary>
    /// Startet das Spiel neu, indem die Scene neu geladen wird.
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}