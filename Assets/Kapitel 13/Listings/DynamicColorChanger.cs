using UnityEngine;

public class DynamicColorChanger : MonoBehaviour
{
    [SerializeField] private Color color;

    private void Start()
    {
        GetComponent<SpriteRenderer>().color = color;
    }
}