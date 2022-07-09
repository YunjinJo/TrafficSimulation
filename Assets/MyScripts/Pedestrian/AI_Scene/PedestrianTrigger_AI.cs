using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianTrigger_AI : MonoBehaviour
{
    public List<PedestrianAI> pedestrianList = new List<PedestrianAI>();

    public TrafficLightsControl trafficLightManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((trafficLightManager.cycleIndex == 3 &&
             trafficLightManager.lightState == TrafficLightsControl.CycleState.Red) || trafficLightManager.cycleIndex != 0 && pedestrianList.Count > 0)
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
        if(other.CompareTag("Pedestrian"))
            pedestrianList.Add(other.GetComponent<PedestrianAI>());
    }
}
