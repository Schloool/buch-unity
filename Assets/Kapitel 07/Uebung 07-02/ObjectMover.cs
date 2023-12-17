using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float minX;
    public float maxX;
    
    private MeshRenderer[] meshRenderers;

    private void Awake()
    {
        meshRenderers = FindObjectsOfType<MeshRenderer>();
    }

    private void Update()
    {
        float xMovement = GetMovement();
        if (Mathf.Approximately(xMovement, 0f)) return;
        
        foreach (MeshRenderer renderer in meshRenderers)
        {
            Vector3 pos = renderer.transform.position;
            float newX = Mathf.Clamp(pos.x + xMovement, minX, maxX);
            renderer.transform.position = new Vector3(newX, pos.y, pos.z);
        }
    }

    private float GetMovement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) return -0.5f;
        if (Input.GetKeyDown(KeyCode.RightArrow)) return 0.5f;

        return 0f;
    }
}
