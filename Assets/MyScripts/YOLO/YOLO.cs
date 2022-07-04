using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOLO : MonoBehaviour
{

    public int Car;

    public int Bus;

    public int Truck;

    public int Firetruck;

    public int Ambulance;
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
            
        }
    }
}
