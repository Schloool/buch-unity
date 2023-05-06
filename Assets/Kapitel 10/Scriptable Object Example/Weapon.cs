using UnityEngine;

[CreateAssetMenu(menuName = "Object/Weapon", fileName = "My Weapon")]
public class Weapon : ScriptableObject
{
    public string name;
    public float attackPower;
}
