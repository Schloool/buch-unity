using TMPro;
using UnityEngine;

public class DropdownTest : MonoBehaviour
{
    private TMP_Dropdown dropdown;

    private void Awake()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    public void HandleSelection(int index)
    {
        string selectedName = dropdown.options[index].text;
        Debug.Log($"Selektiertes Element: {selectedName}");
    }
}