using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillTest : MonoBehaviour
{
    [SerializeField] private float timeToFill;

    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>(); 
    }

    private IEnumerator Start()
    {
        float timePassed = 0f;
        while (timePassed <= timeToFill)
        {
            timePassed += Time.deltaTime;
            image.fillAmount = timePassed / timeToFill;

            yield return null;
        }

        image.fillAmount = 1f;
    }
}