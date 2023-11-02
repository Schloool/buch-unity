using System;
using UnityEngine;

public class MyExceptionTest : MonoBehaviour
{
    private void Start()
    {
        DamagePlayer(5);
        DamagePlayer(-10);
    }

    public void DamagePlayer(int damagePoints)
    {
        if (damagePoints < 0)
        {
            throw new ArgumentException("Negative damage number!");
        }

        Debug.Log($"Spieler erhält {damagePoints} Schaden");
    }
}