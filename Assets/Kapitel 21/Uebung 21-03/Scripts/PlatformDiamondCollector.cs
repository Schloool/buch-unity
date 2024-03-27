using System;
using UnityEngine;

/// <summary>
/// Verwaltungsscript für das Sammeln der Diamanten in der Scene.
/// </summary>
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
        
        collectedCount++;
        OnCollectDiamond?.Invoke(collectedCount);
        diamond.HandleCollection();
    }
}