using UnityEngine;

public class CubeMoveButton : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;

    public void MoveCube(float xValue)
    {
        cubeTransform.position += Vector3.right * xValue;
    }
}