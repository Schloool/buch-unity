using UnityEngine;

public class MouseButtonSaver : MonoBehaviour
{
    private const string playerPrefsKey = "LastButton";

    private void Start()
    {
        int lastIndex = PlayerPrefs.GetInt(playerPrefsKey, -1);
        string output = lastIndex == -1 ? "Keine Taste" : lastIndex.ToString();
        Debug.Log($"Zuletzt gedrückt: {output}");
    }

    private void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            if (Input.GetMouseButtonDown(i))
            {
                PlayerPrefs.SetInt(playerPrefsKey, i);
            }
        }
    }
}