using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class TrafficControl : MonoBehaviour
{
    /*
    Queue<CarAI> trafficQueue = new Queue<CarAI>();
    public CarAI currentCar;

    //[SerializeField]
    //private bool pedestrianWaiting = false, pedestrianWalking = false;

    [SerializeField] private bool carWait = false, carGo = false;

    //[field: SerializeField]
    //public UnityEvent OnPedestrianCanWalk { get; set; }
    
    public TrafficLightsColorControl lightsState;
    //public List<BoxCollider> carLanes = new List<BoxCollider>();
    //public BoxCollider lane = new BoxCollider();
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            var car = other.GetComponent<CarAI>();
            
            if(car != null && car.IsThisLastPathIndex() == false)
            {
                trafficQueue.Enqueue(car);
                //car.Stop = true;
            }
        }
    }
    

    private void Update()
    {
        if (currentCar != null)
        {
            CheckTrafficSignal(lightsState.trafficLights0);
            if (carGo)
                currentCar.Stop = false;
            else if(carWait)
            {
                currentCar.Stop = true;
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            var car = other.GetComponent<CarAI>();
            if(car != null)
            {
                RemoveCar(car);
            }
        }
    }

    private void RemoveCar(CarAI car)
    {
        if(car == currentCar)
        {
            currentCar = null;
        }
    }

    public void CheckTrafficSignal(TrafficLightsColorControl.TrafficLights signal)
    {
        if (currentCar != null)
        {
            if (signal == TrafficLightsColorControl.TrafficLights.GREEN && trafficQueue.Count > 0)
            {
                currentCar = trafficQueue.Dequeue();
                carGo = true;
                carWait = false;
            }
            else if (signal == TrafficLightsColorControl.TrafficLights.YELLOW && trafficQueue.Count > 0)
            {
                carGo = false;
                carWait = true;
            }
            else // red
            {
                carGo = false;
                carWait = true;
            }
        }
        else
        {
            carGo = false;
            carWait = true;
        }
    }
    */
    
    Queue<CarAI> trafficQueue = new Queue<CarAI>();
    public CarAI currentCar;
    
    [SerializeField] private bool carWait = false, carGo = false;
    public TrafficLightsColorControl lightsState;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            var car = other.GetComponent<CarAI>();
            if(car != null && car != currentCar && car.IsThisLastPathIndex() == false)
            {
                trafficQueue.Enqueue(car);
                car.Stop = true;
            }
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if(currentCar == null)
        {
            if(trafficQueue.Count > 0 && lightsState.trafficLights0 == TrafficLightsColorControl.TrafficLights.GREEN)
            {
                currentCar = trafficQueue.Dequeue();
                currentCar.Stop = false;
            }else if(trafficQueue.Count > 0 && lightsState.trafficLights0 is TrafficLightsColorControl.TrafficLights.RED or TrafficLightsColorControl.TrafficLights.YELLOW)
            {
                //OnPedestrianCanWalk?.Invoke();
                //pedestrianWalking = true;
                //currentCar.Stop = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            var car = other.GetComponent<CarAI>();
            if(car != null)
            {
                RemoveCar(car);
            }
        }
    }

    private void RemoveCar(CarAI car)
    {
        if(car == currentCar)
        {
            currentCar = null;
        }
    }
    
}
