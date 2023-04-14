using UnityEngine;

public class RaycastLayerTest : MonoBehaviour
{
    public LayerMask layerMask;
    
    private void Start()
    {
        int myLayer = LayerMask.NameToLayer("Default");
        int another = LayerMask.GetMask("Water", "Ignore Raycast");
        
        if (Physics.Raycast(Vector3.zero, Vector3.up, 5f, another))
        {
            Debug.Log("Objekt auf Layer gefunden!");
        }
    }
}