using System;
using UnityEngine;

/// <summary>
/// Script zur Verwaltung der bisher erzielten Punkte.
/// </summary>
public class ShooterPointCounter : MonoBehaviour
{
    public event Action<int> OnChangePoints;

    public int CurrentPoints => currentPoints;

    private int currentPoints;

    /// <summary>
    /// Fügt dem Punktekonto neue Punkte in Abhängigkeit von einer bestimmten Distanz hinzu.
    ///
    /// Je höher die Distanz (daher der Abstand von Spieler und getroffener Scheibe) war, desto mehr Punkte erhält der
    /// Spieler.
    /// </summary>
    public void AddPointsForDistance(float distance)
    {
        currentPoints += (int) Mathf.Clamp(5 + distance * 5, 10, 50);
        OnChangePoints?.Invoke(currentPoints);
    }
}