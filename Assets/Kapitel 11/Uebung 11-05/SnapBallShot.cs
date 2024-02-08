using System.Collections;
using UnityEngine;

public class SnapBallShot : MonoBehaviour
{
    [SerializeField] private float snapForce;

    private Camera camera;
    private Rigidbody rigidbody;
    private SnapBallGameHandler snapBallGameHandler;
    private Coroutine roundLoseCoroutine;

    private void Awake()
    {
        camera = Camera.main;
        rigidbody = GetComponent<Rigidbody>();
        snapBallGameHandler = FindObjectOfType<SnapBallGameHandler>();
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;

        if (hit.collider.gameObject == gameObject 
            && rigidbody.velocity == Vector3.zero)
        {
            Vector3 direction = (transform.position - hit.point).normalized;
            hit.rigidbody.AddForce(direction * snapForce, ForceMode.Impulse);
            roundLoseCoroutine = StartCoroutine(LoseRoutine());
        }
    }

    private IEnumerator LoseRoutine()
    {
        yield return new WaitForSeconds(2f);
        snapBallGameHandler.FailRound();
    }

    public void StopLoseCoroutine()
    {
        StopCoroutine(roundLoseCoroutine);
    }
}