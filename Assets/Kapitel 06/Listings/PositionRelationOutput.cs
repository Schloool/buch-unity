using UnityEngine;

public class PositionRelationOutput : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"World-Position: {transform.position}");
        Debug.Log($"Relative Position: {transform.localPosition}");
    }
}