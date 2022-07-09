using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PedestrianSpawn : MonoBehaviour
{
    public List<GameObject> spawnPoints = new List<GameObject>();

    public List<GameObject> PedestrianPrebafs = new List<GameObject>();

    public List<GameObject> waypointsList = new List<GameObject>();

    public int maxPedestrian;

    public int currentPedestrian;

    public CountTriggerManager timer;

    private float _timer;

    private int i;

    public int spawnPointIndex;
    
    // Start is called before the first frame update
    void Start()
    {

        maxPedestrian = 20;
        currentPedestrian = 0;
        i = 0;
        spawnPointIndex = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _timer = timer.timerCount;
        if (currentPedestrian != maxPedestrian && Math.Abs(_timer - (10f * (i + 1))) < 0.1)
        {
            SpawnPedestrian();
            currentPedestrian++;
            i++;
        }
    }

    private void SpawnPedestrian()
    {
        var person = Instantiate<GameObject>(PedestrianPrebafs[spawnPointIndex], spawnPoints[spawnPointIndex].transform.position, Quaternion.identity);
        var person_scrpit = person.GetComponent<PedestrianAI>();
        person_scrpit.spawn = this;
        for (int i = 0; i < waypointsList[spawnPointIndex].transform.childCount; i++)
        {
            person_scrpit.waypoints[i] = waypointsList[spawnPointIndex].transform.GetChild(i).transform;
        }
    }
}
