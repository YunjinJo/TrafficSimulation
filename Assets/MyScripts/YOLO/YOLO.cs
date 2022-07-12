using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class YOLO : MonoBehaviour
{

    public int Car;

    public int Special_Car;

    public List<GameObject> detectedCars = new List<GameObject>();

    //public TextMeshProUGUI detectCars;
    
    

    

    public void AddCar(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            detectedCars.Add(other.GameObject());
            Car++;
        }
        else if (other.gameObject.CompareTag("Special_Car"))
        {
            detectedCars.Add(other.GameObject());
            Car++;
            Special_Car++;
        }

        //detectCars.text = "Detected Cars: " + (Car+Special_Car);
    }

    public void SubCar(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            Car--;
        }
        else if (other.gameObject.CompareTag("Special_Car"))
        {
            Car--;
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
