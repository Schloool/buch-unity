using UnityEngine;

public class ErrorClass : MonoBehaviour
{
    private int healthPoints;
    
    // private Void Start()
    // {
    // }

    public void DamagePlayer(int damage)
    {
        healthPoints += damage;
    }
}