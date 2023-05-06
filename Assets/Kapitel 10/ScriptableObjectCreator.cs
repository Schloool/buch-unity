using UnityEngine;

public class ScriptableObjectCreator : MonoBehaviour
{
    private void Awake()
    {
        Weapon weapon = ScriptableObject.CreateInstance<Weapon>();
        weapon.name = "Testwaffe";
        weapon.attackPower = 10f;

        GetComponent<WeaponHolder>().weapon = weapon;
    }
}