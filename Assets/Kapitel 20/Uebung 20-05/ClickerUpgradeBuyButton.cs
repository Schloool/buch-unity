using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickerUpgradeBuyButton : MonoBehaviour
{
    [SerializeField] private ClickerUpgrade upgrade;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text valueText;
    [SerializeField] private TMP_Text costText;

    private Button button;
    private ClickerGameHandler gameHandler;

    private void Awake()
    {
        button = GetComponent<Button>();
        gameHandler = FindObjectOfType<ClickerGameHandler>();
        gameHandler.OnChangePoints += HandlePointsChange;
        gameHandler.OnChangeUpgrades += HandleUpgradesChange;
    }

    private void Start()
    {
        nameText.text = upgrade.name;
        valueText.text = upgrade is ClickerClickUpgrade clickUpgrade
            ? $"+ {clickUpgrade.pointsPerClick} Punkte pro Klick"
            : $"+ {((ClickerTimeUpgrade) upgrade).pointsPerSecond} Punkte pro Sekunde";
    }

    private void OnDestroy()
    {
        gameHandler.OnChangePoints -= HandlePointsChange;
        gameHandler.OnChangeUpgrades -= HandleUpgradesChange;
    }

    private void HandlePointsChange(int points)
    {
        button.interactable = points >= gameHandler.GetCostsForUpgrade(upgrade);
    }

    private void HandleUpgradesChange(List<ClickerUpgrade> upgrades)
    {
        costText.text = $"{gameHandler.GetCostsForUpgrade(upgrade)} Punkte";
    }
}