using UnityEngine;

public class ToggleTest : MonoBehaviour
{
    public void HandleToggle(bool value)
    {
        string message = value ? "an" : "aus";
        Debug.Log($"Der Toggle ist {message}");
    }
}
