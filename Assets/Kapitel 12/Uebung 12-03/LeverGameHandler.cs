using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverGameHandler : MonoBehaviour
{
    [SerializeField] private GameObject gateObject;
    
    private Camera camera;
    
    private void Start()
    {
        camera = Camera.main;
        
        GameLever[] levers = FindObjectsOfType<GameLever>();
        levers[Random.Range(0, levers.Length)].IsWinnerLever = true;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;

        if (!hit.collider.TryGetComponent(out GameLever lever)) return;

        if (lever.IsWinnerLever)
        {
            gateObject.transform.position += Vector3.up * 0.5f;
            StartCoroutine(RestartRoutine());
        }
    }

    private IEnumerator RestartRoutine()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}