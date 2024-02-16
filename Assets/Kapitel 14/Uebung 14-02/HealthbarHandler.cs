using UnityEngine;
using UnityEngine.UI;

public class HealthbarHandler : MonoBehaviour
{
    [SerializeField] private int startHealthPoints;

    private Image healthBarImage;
    private int currentHealthPoints;

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
            healthBarImage.fillAmount = (float) currentHealthPoints / startHealthPoints;
        }
    }
}