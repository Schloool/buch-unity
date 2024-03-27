using UnityEngine;

/// <summary>
/// Scriptable Object für einen bestimmten Typ einer Waffe, der im Spiel platziert werden kann.
/// </summary>
[CreateAssetMenu(menuName = "Tower Defense/Weapon Type")]
public class TowerWeaponType : ScriptableObject
{
    public string name;
    public GameObject model;
    public uint price;
    public float shotInterval;
    public float bulletDamage;
    public float range;
}