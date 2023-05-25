using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Cup")]
public class Cup : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private float diameterInCm;
    [SerializeField] private float heightInCm;

    public float CalculateVolume()
    {
        float radius = diameterInCm / 2f;
        return Mathf.PI * radius * radius * heightInCm;
    }
}