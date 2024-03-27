using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script für die Anzeige der Lebenspunkte des Spielers.
/// </summary>
public class PlatformHealthDisplay : MonoBehaviour
{
    [SerializeField] private Image imagePrefab;
    [SerializeField] private Sprite emptyHeartSprite;
    [SerializeField] private Sprite fullHeartSprite;

    private PlatformPlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<PlatformPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
    }

    private void Start()
    {
        HandleHealthUpdate(playerHealth.MaxHealth);
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    /// <summary>
    /// Behandelt die Änderung der Lebenspunkte, indem je nach verbleibender Anzahl der Lebenspunkte volle oder ganze
    /// Herzen im UI angezeigt werden.
    /// </summary>
    private void HandleHealthUpdate(int health)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
        // Zuerst werden die bereits abgezogenen Herzen in Form eines leeren Containers angezeigt.
        int emptyHealth = playerHealth.MaxHealth - health;
        for (int i = 0; i < emptyHealth; i++)
        {
            Instantiate(imagePrefab, transform).sprite = emptyHeartSprite;
        }
        
        // Zum Schluss folgen die noch verbleibenden "vollen" Herzen.
        for (int i = 0; i < health; i++)
        {
            Instantiate(imagePrefab, transform).sprite = fullHeartSprite;
        }
    }
}