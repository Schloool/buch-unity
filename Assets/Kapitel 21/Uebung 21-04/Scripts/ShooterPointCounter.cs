using System;
using UnityEngine;

public class ShooterPointCounter : MonoBehaviour
{
    public event Action<int> OnChangePoints;

    public int CurrentPoints => currentPoints;

    private int currentPoints;

    public void AddPointsForDistance(float distance)
    {
        currentPoints += (int) Mathf.Max(10, Mathf.Min(5 + distance * 5, 50));
        OnChangePoints?.Invoke(currentPoints);
    }
}