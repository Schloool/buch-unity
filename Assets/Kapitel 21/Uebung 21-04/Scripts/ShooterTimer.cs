using System;
using System.Collections;
using UnityEngine;

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

    public void AddTime(float seconds)
    {
        remainingTime = Mathf.Min(remainingTime + seconds, startTime);
        OnChangeTime?.Invoke(remainingTime);
    }
}