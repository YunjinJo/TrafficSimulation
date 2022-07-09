using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YOLO : MonoBehaviour
{

    public int Car;

    public int Special_Car;

    public List<GameObject> detectedCars = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            detectedCars.Add(other.GameObject());
            Car++;
        }
        else if (other.gameObject.CompareTag("Special_Car"))
        {
            detectedCars.Add(other.GameObject());
            Special_Car++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            Car--;
        }
        else if (other.gameObject.CompareTag("Special_Car"))
        {
            Special_Car--;
        }
        detectedCars.Remove(other.GameObject());
    }

    public int GetCarData()
    {
        return Car;
        
    }

    public int GetSpecialCarData()
    {
        return Special_Car;
    }
}
