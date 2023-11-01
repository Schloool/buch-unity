using UnityEngine;

public class PlatformDiamond : MonoBehaviour
{
    private PlatformDiamondCollector collector;

    private void Start()
    {
        collector = FindObjectOfType<PlatformDiamondCollector>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlatformPlayerMovement>() == null) return;
        
        collector.CollectDiamond();
        Destroy(gameObject);
    }
}