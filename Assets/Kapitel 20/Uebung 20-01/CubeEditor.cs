using UnityEngine;

public class CubeEditor : MonoBehaviour
{
    [SerializeField] private Transform cube;

    public void MoveX(float units)
    {
        Vector3 pos = cube.position;
        pos.x = Mathf.Clamp(pos.x + units, -5f, 5f);
        cube.position = pos;
    }
    
    public void MoveY(float units)
    {
        Vector3 pos = cube.position;
        pos.y = Mathf.Clamp(pos.y + units, -5f, 5f);
        cube.position = pos;
    }
    
    public void Rotate(float units)
    {
        cube.Rotate(Vector3.up * units);
    }

    public void Scale(float units)
    {
        Vector3 scale = cube.localScale;
        float newScale = Mathf.Clamp(scale.x + units, 0.3f, 3f);
        cube.localScale = Vector3.one * newScale;
    }
}