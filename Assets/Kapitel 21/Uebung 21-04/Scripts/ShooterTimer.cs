using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Script zur Verwaltung des Timers, der die verbleibende Zeit zum Treffen der Scheiben bereitstellt.
/// </summary>
public class ShooterTimer : MonoBehaviour
{
    public event Action<float> OnChangeTime;
    public event Action OnTimerEnd;

    public float StartTime => startTime;
    public bool HasFinished => remainingTime < 0f;

    [SerializeField] private float startTime;
    
    private float remainingTime;

    private IEnumerator Start()
    {
        remainingTime = startTime;

        while (!HasFinished)
        {
            remainingTime -= Time.deltaTime;
            OnChangeTime?.Invoke(remainingTime);
            
            yield return null;
        }
        
        OnTimerEnd?.Invoke();
    }

    /// <summary>
    /// Fügt dem Timer Zeit hinzu.
    /// </summary>
    public void AddTime(float seconds)
    {
        remainingTime = Mathf.Min(remainingTime + seconds, startTime);
        OnChangeTime?.Invoke(remainingTime);
    }
}