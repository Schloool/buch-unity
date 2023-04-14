using UnityEngine;

public class FindTagTest : MonoBehaviour
{
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            Debug.Log("Der Spieler wurde in der Scene gefunden.");
        }
    }
}