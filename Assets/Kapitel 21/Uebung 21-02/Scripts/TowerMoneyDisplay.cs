using TMPro;
using UnityEngine;

public class TowerMoneyDisplay : MonoBehaviour
{
    private TMP_Text text;
    private TowerMoneyHandler moneyHandler;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        moneyHandler = FindObjectOfType<TowerMoneyHandler>();
        moneyHandler.OnChangeMoney += HandleChangeMoney;
    }

    private void OnDestroy()
    {
        moneyHandler.OnChangeMoney -= HandleChangeMoney;
    }

    private void HandleChangeMoney(uint money)
    {
        text.text = $"{money}$";
    }
}