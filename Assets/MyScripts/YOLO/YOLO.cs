using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YOLO : MonoBehaviour
{

    public int Car;

    public int Bus;

    public int Truck;

    public int Firetruck;

    public int Ambulance;

    public List<GameObject> detectedCars = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            detectedCars.Add(other.GameObject());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        detectedCars.Remove(other.GameObject());
    }
}
