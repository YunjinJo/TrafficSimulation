using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CountTriggerManager : MonoBehaviour
{
    public float timerCount;
    public int carCount;
    private float deltaTime;
    

    // Start is called before the first frame update
    void Start()
    {
        timerCount = 0;
        carCount = 0;
        deltaTime = Time.deltaTime;
    }

    

    // Update is called once per frame
    void Update()
    {
        timerCount += deltaTime;
        
    }

    public void CountingCars()
    {
        carCount += 1;
    }
}
