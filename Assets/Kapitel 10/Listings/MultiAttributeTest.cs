using UnityEngine;

public class MultiAttributeTest : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Eine einfache Zahl")]
    [Range(0, 100)]
    private int myNumber;
}