using System;
using UnityEngine;

public class FlappyPointHandler : MonoBehaviour
{
    public const string HighscoreKey = "highscore";
    
    public event Action<int> OnChangePoints;

    public int Points { get; private set; }

    public void AddPoint()
    {
        OnChangePoints?.Invoke(++Points);
    }

    public void OverwriteHighscore()
    {
        if (Points <= GetHighscore()) return;
        
        PlayerPrefs.SetInt(HighscoreKey, Points);
    }

    public int GetHighscore()
    {
        return PlayerPrefs.GetInt(HighscoreKey, 0);
    }
}