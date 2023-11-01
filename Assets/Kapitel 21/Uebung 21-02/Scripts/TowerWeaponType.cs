using UnityEngine;

[CreateAssetMenu(menuName = "Tower Defense/Weapon Type")]
public class TowerWeaponType : ScriptableObject
{
    public string name;
    public GameObject model;
    public uint price;
    public float shotFrequency;
    public float bulletDamage;
    public float range;
}