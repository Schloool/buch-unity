using UnityEngine;

public class SaveDataJsonTest : MonoBehaviour
{
    private void Start()
    {
        SaveData saveData = new SaveData();
        saveData.text = "Hallo";
        saveData.number = 20;
        saveData.vector = new Vector3(2f, 0f, -1.5f);
        saveData.script = this;

        string json = JsonUtility.ToJson(saveData);
        Debug.Log(json);
    }
} 