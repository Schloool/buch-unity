using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    public Weapon weapon;

    private void Start()
    {
        AttackWithWeapon();
    }

    private void AttackWithWeapon()
    {
        Debug.Log($"Ich greife mit {weapon.name} an.");
        Debug.Log($"Ich verursache {weapon.attackPower} Schaden.");
        Debug.Log($"Ich verursache {weapon.attackPower} Schaden.");
    }
}