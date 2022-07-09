using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianAI : MonoBehaviour
{
    private NavMeshAgent _agent;

    public Transform[] waypoints;

    private int waypointIndex;

    private Vector3 target;

    [SerializeField] public PedestrianSpawn spawn;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        SetupWaypoints();
        UpdateDestination();
    }

    private void SetupWaypoints()
    {
        for (int i = 0; i < spawn.waypointsList[0].transform.childCount; i++)
        {
            waypoints[i] = spawn.waypointsList[0].transform.GetChild(i);
        }
        
    }

    private void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        _agent.SetDestination(target);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            UpdateDestination();
            IterateWaypointIndex();
            
        }
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            Destroy(this.GameObject());
            spawn.currentPedestrian--;
        }
    }
}
