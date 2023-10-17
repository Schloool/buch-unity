using UnityEngine;
using UnityEngine.SceneManagement;

public class SizeGameCube : MonoBehaviour
{
    public float shrikSpeed;
    public float growForce;

    private void Update()
    {
        transform.localScale -= Vector3.one * shrikSpeed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += Vector3.one * growForce;
        }

        if (transform.localScale.x < 0.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
