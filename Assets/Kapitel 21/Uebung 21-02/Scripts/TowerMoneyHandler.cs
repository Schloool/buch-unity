using System;
using UnityEngine;

/// <summary>
/// Verwaltungsscript für das Geld, das dem Spieler zur Verfügung steht.
/// </summary>
public class TowerMoneyHandler : MonoBehaviour
{
    public event Action<uint> OnChangeMoney;

    public uint CurrentMoney { get; private set; }
    
    [SerializeField] private uint initialMoney;

    private void Start()
    {
        CurrentMoney = 0;
        AddMoney(initialMoney);
    }

    /// <summary>
    /// Fügt einen gegebenen Geldbetrag auf das Konto des Spielers hinzu.
    /// </summary>
    public void AddMoney(uint money)
    {
        CurrentMoney += money;
        OnChangeMoney?.Invoke(CurrentMoney);
    }

    /// <summary>
    /// Versucht, einen bestimmten Geldbetrag vom Konto des Spielers abzuziehen.
    /// 
    /// War das Abziehen erfolgreich, gibt die Methode true zurück.
    /// War zu wenig Geld auf dem Konto des Spielers, gibt die Methode false zurück.
    /// </summary>
    public bool TryRemoveMoney(uint money)
    {
        if (CurrentMoney < money) return false;

        CurrentMoney -= money;
        OnChangeMoney?.Invoke(CurrentMoney);
        return true;
    }
}