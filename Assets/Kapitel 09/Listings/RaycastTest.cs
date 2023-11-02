using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    private void Start()
    {
        if (Physics.Raycast(Vector3.zero, Vector3.up, out RaycastHit hit))
        {
            Debug.Log($"Objekt {hit.transform.name} über (0, 0, 0)");
        }
        else
        {
            Debug.Log("Kein Objekt über (0, 0, 0)");
        }
    }
}
