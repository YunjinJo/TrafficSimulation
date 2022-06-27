using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLights : MonoBehaviour
{
    //Queue<CarAI> trafficQueue = new Queue<CarAI>();
    //public CarAI currentCar;

    //[SerializeField]
    //private bool pedestrianWaiting = false, pedestrianWalking = false;

    //[SerializeField] private bool greenLight = false, yellowLight = false, redLight = true;
    //[SerializeField] private float greenLightTime = 5.0f, yellowLightTime = 5.0f, redLightTime = 5.0f;
    //public List<Renderer> lights = new List<Renderer>();
    public TrafficLightsColorControl lightsState;
    public SmartRoad smartRoad;
    

    //[field: SerializeField]
    //public UnityEvent OnCarCanGo { get; set; }

    /*
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
    */

    private void Update()
    {
        
        if(smartRoad.currentCar != null)
        {
            if(lightsState.trafficLights0 == TrafficLightsColorControl.TrafficLights.GREEN)
            {
                //smartRoad.currentCar = trafficQueue.Dequeue();
                //smartRoad.currentCar.Stop = false;
            }else if(lightsState.trafficLights0 == TrafficLightsColorControl.TrafficLights.RED)
            {
                //OnCarCanGo?.Invoke();
                //smartRoad.currentCar.Stop = true;
            }
        }

        
    }

    /*
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


    public void SetTrafficLightsFlag(bool val)
    {
    }

    */
    
}
