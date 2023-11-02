using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite newSprite;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
