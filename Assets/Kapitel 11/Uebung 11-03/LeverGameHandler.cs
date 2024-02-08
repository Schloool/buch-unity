using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverGameHandler : MonoBehaviour
{
    [SerializeField] private GameObject gateObject;
    [SerializeField] private LayerMask leverMask;
    
    private Camera camera;
    private bool isRestarting;
    
    private void Awake()
    {
        camera = Camera.main;
        
        GameLever[] levers = FindObjectsOfType<GameLever>();
        levers[Random.Range(0, levers.Length)].isWinnerLever = true;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, leverMask))
        {
            GameLever lever = hit.transform.GetComponent<GameLever>();
            CheckLever(lever);
        }
    }

    private void CheckLever(GameLever lever)
    {
        if (lever.isWinnerLever && !isRestarting)
        {
            gateObject.transform.position += Vector3.up * 0.5f;
            isRestarting = true;
            StartCoroutine(RestartRoutine());
        }
    }

    private IEnumerator RestartRoutine()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}