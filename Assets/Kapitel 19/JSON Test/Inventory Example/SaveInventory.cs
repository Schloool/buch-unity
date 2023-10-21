using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveInventory : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> items;

    private string filePath;
    
    private void Start()
    {
        filePath = Application.persistentDataPath + "/inventory.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }

    private void OnDestroy()
    {
        string json = JsonUtility.ToJson(this);
        File.WriteAllText(filePath, json);
    }
}