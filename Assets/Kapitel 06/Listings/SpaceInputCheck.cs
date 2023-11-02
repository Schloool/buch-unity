using UnityEngine;

public class SpaceInputCheck : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste gedrückt!");
        }
    }
}
