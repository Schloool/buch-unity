using System.IO;
using UnityEngine;

public class FileTest : MonoBehaviour
{
    private void Start()
    {
        string filePath = Application.persistentDataPath + "/test.txt";
        Debug.Log(filePath);
        
        File.WriteAllText(filePath, "Hallo Textwelt!");

        if (File.Exists(filePath))
        {
            string text = File.ReadAllText(filePath);
            Debug.Log(text);
        }
    }
}