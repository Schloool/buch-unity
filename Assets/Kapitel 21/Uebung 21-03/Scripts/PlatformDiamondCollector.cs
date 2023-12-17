using System;
using UnityEngine;

public class PlatformDiamondCollector : MonoBehaviour
{
    public event Action<int> OnCollectDiamond;
    
    public int AllDiamondCount { get; private set; }
    
    private int collectedCount;

    private void Awake()
    {
        AllDiamondCount = FindObjectsOfType<PlatformDiamond>().Length;
        collectedCount = 0;
    }

    public void CollectDiamond()
    {
        OnCollectDiamond?.Invoke(++collectedCount);
    }
}