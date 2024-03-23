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
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.TryGetComponent(out PlatformDiamond diamond)) return;
        
        CollectDiamond();
        diamond.HandleCollection();
    }

    public void CollectDiamond()
    {
        collectedCount++;
        OnCollectDiamond?.Invoke(collectedCount);
    }
}