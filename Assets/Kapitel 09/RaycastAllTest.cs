using UnityEngine;

public class RaycastAllTest : MonoBehaviour
{
    private void Start()
    {
        RaycastHit[] hits = Physics.RaycastAll(Vector3.zero, Vector3.up);
        if (hits != null)
        {
            Debug.Log("Ein oder mehrere Objekte gefunden:");
            foreach (RaycastHit hit in hits)
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}