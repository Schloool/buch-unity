using UnityEngine;

public class EnemyMethod : MonoBehaviour
{
    private void Start()
    {
        PrintEnemyData("Wolf", 20, 5.5f);
    }

    private void PrintEnemyData(string name, int attack, float range)
    {
        Debug.Log($"Der Gegner {name} hat {attack} Angriff.");
        Debug.Log($"Seine Reichweite beträgt {range}.");
    }
}
