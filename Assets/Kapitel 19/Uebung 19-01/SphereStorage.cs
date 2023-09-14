using System.Collections.Generic;
using UnityEngine;

public class SphereStorage : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;
    
    private List<GameObject> spheres;

    private void Start()
    {
        spheres = new List<GameObject>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5));
            spheres.Add(Instantiate(spherePrefab, pos, Quaternion.identity));
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (GameObject sphere in spheres)
            {
                Destroy(sphere);
            }
            spheres.Clear();
        }
    }
}
