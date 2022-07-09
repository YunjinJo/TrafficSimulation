using System;
using System.Collections;
using System.Collections.Generic;
using TurnTheGameOn.SimpleTrafficSystem;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class PedestrianAI : MonoBehaviour
{
    private NavMeshAgent _agent;

    public Transform[] waypoints;

    private int waypointIndex;

    private Vector3 target;

    [SerializeField] public PedestrianSpawn spawn;

    //public AITrafficLightManager trafficLight;

    private Animator anim;

    
    private static readonly int Walks = Animator.StringToHash("Walks");

    private float move_speed;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        SetupWaypoints();
        UpdateDestination();
        anim = this.GetComponent<Animator>();
        anim.SetBool(Walks, true);
        move_speed = Random.Range(2.0f, 6.0f);
        _agent.speed = move_speed;
    }

    private void SetupWaypoints()
    {
        for (int i = 0; i < spawn.waypointsList[0].transform.childCount; i++)
        {
            //waypoints[i] = spawn.waypointsList[0].transform.GetChild(i);
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
        }
    }

    public void Agent_Stop()
    {
        _agent.isStopped = true;
        _agent.velocity = Vector3.zero;
        anim.SetBool(Walks, false);
    }

    public void Agent_Go()
    {
        _agent.isStopped = false;
        anim.SetBool(Walks, true);
    }
}
