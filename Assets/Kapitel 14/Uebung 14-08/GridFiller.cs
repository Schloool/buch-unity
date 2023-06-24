using UnityEngine;

public class GridFiller : MonoBehaviour
{
    [SerializeField] private GameObject imagePrefab;
    
    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(imagePrefab, transform);
        }
    }
}