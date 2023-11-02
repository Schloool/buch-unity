using UnityEngine;
using UnityEngine.AI;

public class AgentMover : MonoBehaviour
{
    private NavMeshAgent agent;
    private Camera camera;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        camera = Camera.main;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            agent.SetDestination(hit.point);
        }
    }
}
