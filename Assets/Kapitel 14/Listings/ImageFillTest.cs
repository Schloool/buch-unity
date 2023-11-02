using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillTest : MonoBehaviour
{
    [SerializeField] private float timeToFill;
    
    private IEnumerator Start()
    {
        Image image = GetComponent<Image>(); 
        
        float timePassed = 0f;
        while (timePassed <= timeToFill)
        {
            timePassed += Time.deltaTime;
            image.fillAmount = timePassed / timeToFill;

            yield return null;
        }
    }
}