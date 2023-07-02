using UnityEngine;

public class DestructionRay : MonoBehaviour
{
    private Camera camera;
    
    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
