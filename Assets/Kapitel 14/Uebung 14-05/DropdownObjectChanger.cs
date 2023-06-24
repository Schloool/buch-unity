using System;
using UnityEngine;

public class DropdownObjectChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;

    private GameObject currentObject;

    private void Start()
    {
        HandleChange(0);
    }

    public void HandleChange(int index)
    {
        if (currentObject != null)
        {
            Destroy(currentObject);
        }

        currentObject = Instantiate(prefabs[index]);
    }
}