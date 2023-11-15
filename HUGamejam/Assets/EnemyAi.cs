using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent component not found on this GameObject.");
        }
    }

    Vector3 GetRandomPosition()
    {
        NavMeshHit navMeshHit;
        Vector3 randomPosition;

        // Repeat until a valid random position on the NavMesh is found
        do
        {
            float randomX = Random.Range(-25f, 25f); // Adjust the range based on your map size
            float randomZ = Random.Range(-25f, 25f);

            randomPosition = new Vector3(randomX, 0f, randomZ) + transform.position;
        } while (!NavMesh.SamplePosition(randomPosition, out navMeshHit, 1.0f, NavMesh.AllAreas));

        return navMeshHit.position;
    }

    void Update()
    {
        MoveToRandomPosition();
    }

    void MoveToRandomPosition()
    {
        Vector3 randomPosition = GetRandomPosition();
        navMeshAgent.SetDestination(randomPosition);
    }
}
