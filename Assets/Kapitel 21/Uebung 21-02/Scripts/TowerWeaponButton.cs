using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script für einen Button, der einen bestimmten Waffentyp kauft.
/// </summary>
public class TowerWeaponButton : MonoBehaviour
{
    [SerializeField] private TowerWeaponType weaponType;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text priceText;

    private Button button;
    private TowerMoneyHandler moneyHandler;
    private TowerWeaponBuilder weaponBuilder;

    private void Awake()
    {
        button = GetComponent<Button>();
        moneyHandler = FindObjectOfType<TowerMoneyHandler>();
        moneyHandler.OnChangeMoney += HandleChangeMoney;
        weaponBuilder = FindObjectOfType<TowerWeaponBuilder>();
    }

    private void Start()
    {
        nameText.text = weaponType.name;
        priceText.text = $"{weaponType.price}$";
        
        HandleChangeMoney(moneyHandler.CurrentMoney);
    }

    private void OnDestroy()
    {
        moneyHandler.OnChangeMoney -= HandleChangeMoney;
    }

    /// <summary>
    /// Kauft diesen Waffentyp.
    ///
    /// Das Platzieren ist nur möglich, wenn aktuell nicht schon eine Waffe platziert wird.
    /// Ist genug Geld vorhanden, startet sofort der Platzierungsvorgang für die neue Waffe.
    /// </summary>
    public void Buy()
    {
        if (weaponBuilder.CurrentWeapon != null) return;

        if (moneyHandler.TryRemoveMoney(weaponType.price))
        {
            StartCoroutine(weaponBuilder.StartPlacement(weaponType));
        }
    }

    /// <summary>
    /// Behandelt die Änderung des Geldes des Spielerkontos, indem der Button deaktiviert wird, wenn nicht mehr genügend
    /// Geld zum Kaufen der Waffe übrig ist.
    /// </summary>
    private void HandleChangeMoney(uint money)
    {
        button.interactable = money >= weaponType.price;
    }
}