using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqTest : MonoBehaviour
{
    private void Start()
    {
        List<GameItem> items = new List<GameItem>()
        {
            new GameItem("Schwert", 4),
            new GameItem("Zauberstab", 10),
            new GameItem("Sack", 1),
        };
        
        foreach (GameItem item in items)
        {
            Debug.Log($"{item.name} (Level {item.level})");
        }
        
        GameItem itemWithHighestLevel;
        int highestLevel = -1;
        foreach (GameItem item in items)
        {
            if (item.level > highestLevel)
            {
                itemWithHighestLevel = item;
                highestLevel = item.level;
            }
        }

        
        items.ForEach(item => Debug.Log($"{item.name} (Level {item.level})"));
        
        items.Where(item => item.level > 3)
            .ToList()
            .ForEach(item => Debug.Log($"{item.name} (Level {item.level})"));

        items.All(item => item.level > 5);
        items.Any(item => item.level > 5);
        items.Count(item => item.name.Length > 6);
        items.First(item => item.name.StartsWith('Z'));
        items.FirstOrDefault(item => item.name.StartsWith('F'));
        items.Select(item => item.name).ToList();
        items.Sum(item => item.level);
        items.Min(item => item.level);
        items.Max(item => item.level);
        items.Average(item => item.level);
        items.OrderBy(item => item.level);
    }
}
