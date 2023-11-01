using System;
using UnityEngine;

public class TowerMoneyHandler : MonoBehaviour
{
    public event Action<uint> OnChangeMoney;

    public uint CurrentMoney => currentMoney;

    [SerializeField] private uint currentMoney;

    private void Start()
    {
        OnChangeMoney?.Invoke(currentMoney);
    }

    public void AddMoney(uint money)
    {
        currentMoney += money;
        OnChangeMoney?.Invoke(currentMoney);
    }

    public void RemoveMoney(uint money)
    {
        if (currentMoney < money) return;

        currentMoney -= money;
        OnChangeMoney?.Invoke(currentMoney);
    }
}