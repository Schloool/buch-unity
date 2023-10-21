using UnityEngine;

public class LoadDataJsonTest : MonoBehaviour
{
    private void Start()
    {
        string json = "{\"text\":\"Hallo\",\"number\":20,\"vector\":{\"x\":2.0,\"y\":0.0,\"z\":-1.5},\"script\":{\"instanceID\":-2520}}";
        SaveData saveData = JsonUtility.FromJson<SaveData>(json);
        
        Debug.Log(saveData.text);
        Debug.Log(saveData.number);
        Debug.Log(saveData.vector.x);
        Debug.Log(saveData.script.gameObject.name);
    }
}