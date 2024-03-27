using TMPro;
using UnityEngine;

/// <summary>
/// Script für die Anzeige des aktuell zur Verfügung stehenden Gelds.
/// </summary>
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

    /// <summary>
    /// Reagiert auf Änderungen des Spieler-Gelds und aktualisiert die entsprechende UI-Textanzeige.
    /// </summary>
    private void HandleChangeMoney(uint money)
    {
        text.text = $"{money}$";
    }
}