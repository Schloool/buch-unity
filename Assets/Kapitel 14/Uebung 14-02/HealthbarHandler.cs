using UnityEngine;
using UnityEngine.UI;

public class HealthbarHandler : MonoBehaviour
{
    [SerializeField] private float startHealthPoints;

    private Image healthBarImage;
    private float currentHealthPoints;

    private void Awake()
    {
        healthBarImage = GetComponent<Image>();
        currentHealthPoints = startHealthPoints;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentHealthPoints > 0)
        {
            currentHealthPoints--;
            healthBarImage.fillAmount = currentHealthPoints / startHealthPoints;
        }
    }
}