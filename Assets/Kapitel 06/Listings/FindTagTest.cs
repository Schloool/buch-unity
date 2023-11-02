using UnityEngine;

public class FindTagTest : MonoBehaviour
{
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 playerPosition = player.transform.position;
        Debug.Log($"Spieler-Position: {playerPosition}");
    }
}