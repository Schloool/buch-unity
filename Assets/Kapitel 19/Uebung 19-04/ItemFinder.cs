using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemFinder : MonoBehaviour
{
    private void Start()
    {
        List<GameItem> items = new List<GameItem>()
        {
            new GameItem("Schwert", 4),
            new GameItem("Zauberstab", 10),
            new GameItem("Sack", 1),
        };

        items.Where(item => item.name.StartsWith('S'))
            .ToList()
            .ForEach(item => Debug.Log(item.name));
        
        GameItem highestLevel = items.OrderBy(item => item.level)
            .FirstOrDefault();
        
        double averageLongLevel = items.Where(item => item.name.Length > 4)
            .Average(item => item.level);
    }
}