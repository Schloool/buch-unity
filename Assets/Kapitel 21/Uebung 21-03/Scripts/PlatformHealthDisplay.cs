using System;
using UnityEngine;
using UnityEngine.UI;

public class PlatformHealthDisplay : MonoBehaviour
{
    [SerializeField] private Image imagePrefab;
    [SerializeField] private Sprite emptyHeartSprite;
    [SerializeField] private Sprite fullHeartSprite;

    private PlatformPlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlatformPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
        
        HandleHealthUpdate(playerHealth.MaxHealth);
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    private void HandleHealthUpdate(int health)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
        int emptyHealth = playerHealth.MaxHealth - health;
        for (int i = 0; i < emptyHealth; i++)
        {
            Instantiate(imagePrefab, transform).sprite = emptyHeartSprite;
        }
        
        for (int i = 0; i < health; i++)
        {
            Instantiate(imagePrefab, transform).sprite = fullHeartSprite;
        }
    }
}