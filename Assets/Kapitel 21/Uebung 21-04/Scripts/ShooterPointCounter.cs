using System;
using UnityEngine;

public class ShooterPointCounter : MonoBehaviour
{
    public event Action<int> OnChangePoints;

    public int CurrentPoints => currentPoints;

    private int currentPoints;

    public void AddPointsForDistance(float distance)
    {
        currentPoints += (int) Mathf.Clamp(5 + distance * 5, 10, 50);
        OnChangePoints?.Invoke(currentPoints);
    }
}