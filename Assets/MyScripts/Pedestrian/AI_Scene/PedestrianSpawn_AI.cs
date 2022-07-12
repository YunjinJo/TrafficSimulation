using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PedestrianSpawn_AI : MonoBehaviour
{
    public List<GameObject> spawnPoints = new List<GameObject>();

    public List<GameObject> PedestrianPrebafs = new List<GameObject>();

    public List<GameObject> waypointsList = new List<GameObject>();

    public List<GameObject> spawned = new List<GameObject>();

    public int maxPedestrian;

    public int currentPedestrian;

    public CountTriggerManager timer;

    private float _timer;

    private int i;

    public int spawnPointIndex;
    //public AITrafficLightManager trafficLightManager;
    
    
    // Start is called before the first frame update
    void Start()
    {

        maxPedestrian = 100;
        currentPedestrian = 0;
        i = 0;
        spawnPointIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _timer = timer.timerCount;
        if (currentPedestrian != maxPedestrian && Math.Abs(_timer - (5f * (i + 1))) < 0.1)
        {
            spawnPointIndex = Random.Range(0, 4);
            SpawnPedestrian(spawnPointIndex);
            currentPedestrian++;
            i++;
        }

        for (int j = 0; j < spawned.Count; j++)
        {
            if (spawned[j] == null)
            {
                spawned.RemoveAt(j);
                currentPedestrian--;
            }
        }
    }

    private void SpawnPedestrian(int index)
    {
        var person = Instantiate<GameObject>(PedestrianPrebafs[0], spawnPoints[index].transform.position, Quaternion.identity);
        spawned.Add(person);
        var person_scrpit = person.GetComponent<PedestrianAI_AI>();
        person_scrpit.spawn = this;
        //person_scrpit.trafficLight = trafficLightManager;
        for (int i = 0; i < waypointsList[index].transform.childCount; i++)
        {
            person_scrpit.waypoints[i] = waypointsList[index].transform.GetChild(i).transform;
        }
    }
}
