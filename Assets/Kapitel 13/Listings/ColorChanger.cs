using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}