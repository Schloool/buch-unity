using UnityEngine;

public class ErrorClass : MonoBehaviour
{
    private int healthPoints;

    // private void Start
    // {
    // }

    public void DamagePlayer(int damage)
    {
        healthPoints += damage;
    }
}