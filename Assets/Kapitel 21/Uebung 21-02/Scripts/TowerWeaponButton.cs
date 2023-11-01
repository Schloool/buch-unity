using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TowerWeaponButton : MonoBehaviour
{
    [SerializeField] private TowerWeaponType weaponType;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text priceText;

    private Button button;
    private TowerMoneyHandler moneyHandler;
    private TowerWeaponBuilder weaponBuilder;

    private void Start()
    {
        button = GetComponent<Button>();
        moneyHandler = FindObjectOfType<TowerMoneyHandler>();
        moneyHandler.OnChangeMoney += HandleChangeMoney;
        weaponBuilder = FindObjectOfType<TowerWeaponBuilder>();

        nameText.text = weaponType.name;
        priceText.text = $"{weaponType.price}$";
        
        HandleChangeMoney(moneyHandler.CurrentMoney);
    }

    private void OnDestroy()
    {
        moneyHandler.OnChangeMoney -= HandleChangeMoney;
    }

    public void Buy()
    {
        if (weaponBuilder.CurrentWeapon != null) return;
        
        moneyHandler.RemoveMoney(weaponType.price);
        weaponBuilder.StartPlacement(weaponType);
    }

    private void HandleChangeMoney(uint money)
    {
        button.interactable = money >= weaponType.price;
    }
}