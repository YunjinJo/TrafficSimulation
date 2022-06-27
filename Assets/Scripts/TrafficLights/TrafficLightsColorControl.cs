using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightsColorControl : MonoBehaviour
{
    
    
    [SerializeField] private float greenLightTime = 5.0f, yellowLightTime = 5.0f, redLightTime = 5.0f;
    public List<Renderer> lights0 = new List<Renderer>();
    public List<Renderer> lights1 = new List<Renderer>();
    public List<Renderer> lights2 = new List<Renderer>();
    
    public enum TrafficLights
    {
        RED,
        YELLOW,
        GREEN
    }

    public TrafficLights trafficLights0 = TrafficLights.RED;
    public TrafficLights trafficLights1 = TrafficLights.RED;
    public TrafficLights trafficLights2 = TrafficLights.GREEN;
    
    void Start()
    {
        foreach (var lightColor in lights0)
        {
            lightColor.material.color = Color.black;
        }
        
        foreach (var lightColor in lights1)
        {
            lightColor.material.color = Color.black;
        }
        
        foreach (var lightColor in lights2)
        {
            lightColor.material.color = Color.black;
        }
        ChangeColor(trafficLights0, lights0);
        ChangeColor(trafficLights1, lights1);
        ChangeColor(trafficLights2, lights2);
        
    }

    
    void Update()
    {
        TrafficLightsTimer();
    }
    
    public void TrafficLightsTimer()
    {
        if (trafficLights0 == TrafficLights.GREEN && trafficLights1 == TrafficLights.GREEN &&
            trafficLights2 == TrafficLights.RED)
        {
            greenLightTime -= Time.deltaTime;
            if (greenLightTime <= 0.0f)
            {
                trafficLights0 = TrafficLights.YELLOW;
                ChangeColor(trafficLights0, lights0);
                trafficLights1 = TrafficLights.YELLOW;
                ChangeColor(trafficLights1, lights1);
                trafficLights2 = TrafficLights.RED;
                ChangeColor(trafficLights2, lights2);
                greenLightTime = 5.0f;
            }
        }
        
        else if (trafficLights0 == TrafficLights.YELLOW && trafficLights1 == TrafficLights.YELLOW &&
            trafficLights2 == TrafficLights.RED)
        {
            yellowLightTime -= Time.deltaTime;
            if (yellowLightTime <= 0.0f)
            {
                trafficLights0 = TrafficLights.RED;
                ChangeColor(trafficLights0, lights0);
                trafficLights1 = TrafficLights.RED;
                ChangeColor(trafficLights1, lights1);
                trafficLights2 = TrafficLights.GREEN;
                ChangeColor(trafficLights2, lights2);
                yellowLightTime = 5.0f;
            }
        }
        
        else if (trafficLights0 == TrafficLights.RED && trafficLights1 == TrafficLights.RED &&
            trafficLights2 == TrafficLights.GREEN)
        {
            redLightTime -= Time.deltaTime;
            if (redLightTime <= 0.0f)
            {
                trafficLights0 = TrafficLights.RED;
                trafficLights1 = TrafficLights.RED;
                trafficLights2 = TrafficLights.YELLOW;
                ChangeColor(trafficLights0, lights0);
                ChangeColor(trafficLights1, lights1);
                ChangeColor(trafficLights2, lights2);
                redLightTime = 5.0f;
            }
        }
        
        else if (trafficLights0 == TrafficLights.RED && trafficLights1 == TrafficLights.RED &&
            trafficLights2 == TrafficLights.YELLOW)
        {
            yellowLightTime -= Time.deltaTime;
            if (yellowLightTime <= 0.0f)
            {
                trafficLights0 = TrafficLights.GREEN;
                trafficLights1 = TrafficLights.GREEN;
                trafficLights2 = TrafficLights.RED;
                ChangeColor(trafficLights0, lights0);
                ChangeColor(trafficLights1, lights1);
                ChangeColor(trafficLights2, lights2);
                yellowLightTime = 5.0f;
            }
        }
    }

    public void ChangeColor(TrafficLights trafficLights, List<Renderer> list)
    {
        if (trafficLights == TrafficLights.RED)
        {
            list[0].material.color = Color.red;
            list[1].material.color = Color.black;
            list[2].material.color = Color.black;
        }
        else if (trafficLights == TrafficLights.YELLOW)
        {
            list[0].material.color = Color.black;
            list[1].material.color = Color.yellow;
            list[2].material.color = Color.black;
        }
        
        else if (trafficLights == TrafficLights.GREEN)
        {
            list[0].material.color = Color.black;
            list[1].material.color = Color.black;
            list[2].material.color = Color.green;
        }
        
    }
}
