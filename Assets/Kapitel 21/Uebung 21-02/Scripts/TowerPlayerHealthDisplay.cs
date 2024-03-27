using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script für die Anzeige der Lebenspunkte des Spielers.
/// </summary>
public class TowerPlayerHealthDisplay : MonoBehaviour
{
    private Image fillImage;
    private TowerPlayerHealth playerHealth;

    private void Awake()
    {
        fillImage = GetComponent<Image>();
        playerHealth = FindObjectOfType<TowerPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    /// <summary>
    /// Behandelt die Veränderung der Lebenspunkte, indem das Bild für die Lebensleiste mit dem verbleibenden Anteil
    /// gefüllt wird.
    /// </summary>
    private void HandleHealthUpdate(float health)
    {
        fillImage.fillAmount = health / playerHealth.MaxHealth;
    }
}