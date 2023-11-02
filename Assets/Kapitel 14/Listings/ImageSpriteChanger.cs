using UnityEngine;
using UnityEngine.UI;

public class ImageSpriteChanger : MonoBehaviour
{
    [SerializeField] private Sprite newSprite;
    
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            image.sprite = newSprite;
        }
    }
}
