using UnityEngine;

[CreateAssetMenu(menuName = "Tower Defense/Enemy Type")]
public class TowerEnemyType : ScriptableObject
{
    public GameObject model;
    public float speed;
    public float healthPoints;
    public float damage;
    public uint moneyOnKill;
}