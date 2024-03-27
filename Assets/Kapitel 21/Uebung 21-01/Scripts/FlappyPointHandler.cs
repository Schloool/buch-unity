using System;
using UnityEngine;

/// <summary>
/// Klasse zur Verwaltung der erzielten Punkte.
/// Mithilfe der PlayerPrefs ist das Script ebenfalls für das Speichern des Highscores zuständig.
/// </summary>
public class FlappyPointHandler : MonoBehaviour
{
    public const string HighscoreKey = "highscore";
    
    public event Action<int> OnChangePoints;

    public int Points { get; private set; }

    /// <summary>
    /// Fügt dem Punktekonto einen weiteren Punkt hinzu.
    /// </summary>
    public void AddPoint()
    {
        Points++;
        OnChangePoints?.Invoke(Points);
    }

    /// <summary>
    /// Überschreibt den Highscore mit dem aktuell erzielten Punktewert.
    /// Die Methode tut nichts, wenn die Punkte den Highscore nicht überbieten.
    /// </summary>
    public void OverwriteHighscore()
    {
        if (Points <= GetHighscore()) return;
        
        PlayerPrefs.SetInt(HighscoreKey, Points);
    }

    /// <summary>
    /// Ruft den aktuellen Highscore-Punktewert ab.
    /// </summary>
    public int GetHighscore()
    {
        return PlayerPrefs.GetInt(HighscoreKey, 0);
    }
}