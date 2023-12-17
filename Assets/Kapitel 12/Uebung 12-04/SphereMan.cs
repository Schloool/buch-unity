using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereMan : MonoBehaviour
{
    private GameObject[] spheres;
    
    [SerializeField] private float speed;

    private void Awake()
    {
        spheres = FindObjectOfType<SphereManEditor>().PlacedSpheres;
    }

    private IEnumerator Start()
    {
        while (true)
        {
            foreach (GameObject sphere in spheres)
            {
                while (Vector3.Distance(transform.position, sphere.transform.position) > 0.1f)
                {
                    Vector3 direction = (sphere.transform.position - transform.position).normalized;
                    transform.position += direction * speed * Time.deltaTime;
                    yield return null;
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}