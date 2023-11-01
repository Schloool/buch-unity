using UnityEngine;
using UnityEngine.UI;

public class TowerPlayerHealthDisplay : MonoBehaviour
{
    private Image fillImage;
    private TowerPlayerHealth playerHealth;

    private void Start()
    {
        fillImage = GetComponent<Image>();
        playerHealth = FindObjectOfType<TowerPlayerHealth>();
        playerHealth.OnHealthUpdate += HandleHealthUpdate;
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthUpdate -= HandleHealthUpdate;
    }

    private void HandleHealthUpdate(float health)
    {
        fillImage.fillAmount = health / playerHealth.MaxHealth;
    }
}