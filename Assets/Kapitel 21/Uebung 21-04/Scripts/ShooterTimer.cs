using System;
using System.Collections;
using UnityEngine;

public class ShooterTimer : MonoBehaviour
{
    public event Action<float> OnChangeTime;
    public event Action OnTimerEnd;
    
    public float RemainingTime { get; private set; }
    public float StartTime => startTime;

    [SerializeField] private float startTime;

    private IEnumerator Start()
    {
        RemainingTime = startTime;

        while (RemainingTime > 0f)
        {
            RemainingTime -= Time.deltaTime;
            OnChangeTime?.Invoke(RemainingTime);
            
            yield return null;
        }
        
        OnTimerEnd?.Invoke();
    }

    public void AddTime(float seconds)
    {
        RemainingTime = Mathf.Min(RemainingTime + seconds, startTime);
        OnChangeTime?.Invoke(RemainingTime);
    }
}