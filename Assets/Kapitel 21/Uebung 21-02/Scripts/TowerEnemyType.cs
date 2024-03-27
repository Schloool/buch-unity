using UnityEngine;

/// <summary>
/// Scriptable Object für einen Gegner-Typ, der im Laufe einer Welle erscheinen kann.
/// </summary>
[CreateAssetMenu(menuName = "Tower Defense/Enemy Type")]
public class TowerEnemyType : ScriptableObject
{
    public GameObject model;
    public float speed;
    public float healthPoints;
    public float damage;
    public uint moneyOnKill;
}