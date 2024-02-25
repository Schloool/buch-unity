using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class ClickerGameHandler : MonoBehaviour
{
    public event Action<int> OnChangePoints;
    public event Action OnChangeUpgrades;

    private int Points
    {
        get => points;
        set
        {
            points = value;
            OnChangePoints?.Invoke(points);
        }
    }

    private string saveFilePath;
    
    [SerializeField] [HideInInspector] private int points;
    [SerializeField] [HideInInspector] private List<ClickerUpgrade> upgrades;

    private void Awake()
    {
        saveFilePath = Application.persistentDataPath + "/clicker.json";
        if (File.Exists(saveFilePath))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(saveFilePath), this);
        }
        else
        {
            points = 0;
            upgrades = new List<ClickerUpgrade>();
        }
    }

    private void Start()
    {
        OnChangePoints?.Invoke(points);
        OnChangeUpgrades?.Invoke();
        StartCoroutine(TimeUpgradeRoutine());
    }

    private void OnDestroy()
    {
        File.WriteAllText(saveFilePath, JsonUtility.ToJson(this));
    }

    public void Click()
    {
        Points += GetPointsPerClick();
    }

    private IEnumerator TimeUpgradeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Points += GetPointsPerSecond();
        }
    }

    public int GetPointsPerClick()
    {
        return 1 + upgrades.Sum(clickerUpgrade => clickerUpgrade.pointsPerClick);
    }

    public int GetPointsPerSecond()
    {
        return upgrades.Sum(timeUpgrade => timeUpgrade.pointsPerSecond);
    }

    public int GetCostsForUpgrade(ClickerUpgrade newUpgrade)
    {
        int level = upgrades.Count(upgrade => upgrade == newUpgrade);
        return newUpgrade.GetCostsForLevel(level + 1);
    }
    
    public void BuyUpgrade(ClickerUpgrade upgrade)
    {
        int costs = GetCostsForUpgrade(upgrade);
        if (costs > points) return;

        Points -= costs;
        upgrades.Add(upgrade);
        OnChangeUpgrades?.Invoke();
    }
}