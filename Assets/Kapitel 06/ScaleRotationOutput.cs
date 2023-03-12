using UnityEngine;

public class ScaleRotationOutput : MonoBehaviour
{
    private void Start()
    {
        Debug.Log($"Rotation: {transform.eulerAngles}");
        Debug.Log($"Skalierung: {transform.localScale}");
    }
}