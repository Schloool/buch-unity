using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float speed = 5;
    public string name = "Erika";

    public void LoadFromJson(string json)
    {
        JsonUtility.FromJsonOverwrite(json, this);
    }
}