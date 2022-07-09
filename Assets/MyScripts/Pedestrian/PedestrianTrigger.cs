using System;
using System.Collections;
using System.Collections.Generic;
using TurnTheGameOn.SimpleTrafficSystem;
using Unity.VisualScripting;
using UnityEngine;

public class PedestrianTrigger : MonoBehaviour
{
    public List<PedestrianAI> pedestrianList = new List<PedestrianAI>();

    public AITrafficLightManager trafficLightManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((trafficLightManager.cycleIndex == 0 &&
             trafficLightManager.lightState == AITrafficLightManager.CycleState.Red) || trafficLightManager.cycleIndex != 0)
        {
            for (int i = 0; i < pedestrianList.Count; i++)
            {
                pedestrianList[i].Agent_Stop();
            }
        }
        else
        {
            for (int i = 0; i < pedestrianList.Count; i++)
            {
                pedestrianList[i].Agent_Go();
                pedestrianList.RemoveAt(i);
                
            }

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pedestrianList.Add(other.GetComponent<PedestrianAI>());
    }

}
