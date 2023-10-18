using System;
using System.Collections;
using UnityEngine;

public class RaceCountdown : MonoBehaviour
{
    public event Action<int> OnChangeTimer;

    private int countdown;

    private IEnumerator Start()
    {
        for (countdown = 3; countdown >= 0; countdown--)
        {
            OnChangeTimer?.Invoke(countdown);
            yield return new WaitForSeconds(1f);
        }
    }
}