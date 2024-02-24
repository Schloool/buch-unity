using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshCube : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private IEnumerator Start()
    {
        while (true)
        {
            Vector3 randomPoint = points[Random.Range(0, points.Length)].position;
            agent.SetDestination(randomPoint);
            yield return new WaitForSeconds(3f);
        }
    }
}
