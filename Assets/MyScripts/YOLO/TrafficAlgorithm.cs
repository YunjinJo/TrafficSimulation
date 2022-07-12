using System;
using System.Collections;
using System.Collections.Generic;
using TurnTheGameOn.SimpleTrafficSystem;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class TrafficAlgorithm : MonoBehaviour
{
    //public YOLO yolo;
    public List<YOLO> yolos = new List<YOLO>();
    public CountTriggerManager timer;
    public TrafficLightsControl trafficLightManager;
    private float _timer;
    private float _ex_timer;

    public float internaltimer;
    public float test_deltaTime_current;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        _ex_timer = 0;
        internaltimer = 0;
        index = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _timer = timer.timerCount;
        if (!(_timer - _ex_timer > 1.0f)) return;
        
        
        if ((trafficLightManager.cycleIndex != 3) && trafficLightManager.lightState == TrafficLightsControl.CycleState.Green) // 보행자용 신호등이 아닐때
        {
            internaltimer += InternalTimeflow(internaltimer); // deltaTime 흐름
        }
        else if (trafficLightManager.cycleIndex == 3 || trafficLightManager.lightState == TrafficLightsControl.CycleState.Red || trafficLightManager.lightState == TrafficLightsControl.CycleState.Yellow)
        {
            //SpecialCarDetect();
            test_deltaTime_current = 1.0f;
        }
        else
        {
            internaltimer = 0f;
        }
        _ex_timer = _timer;
    }
    private float InternalTimeflow(float deltaTime)
    {
        if (index == 3) return 1.0f;
        if (yolos[index].GetSpecialCarData() > 0)
        {
            deltaTime += 0.01f;
            test_deltaTime_current = 0.01f;
        }

        else if (yolos[index].GetCarData() >= 4) // 차량 4대 이상
        {
            deltaTime += 0.5f;
            test_deltaTime_current = 0.5f;
        }
        else if (yolos[index].GetCarData() >= 3) // 차량 3대 이상
        {
            deltaTime += 0.9f;
            test_deltaTime_current = 0.9f;
        }
        else if (yolos[index].GetCarData() >= 2) // 차량 2대 이상
        {
            deltaTime += 1.0f;
            test_deltaTime_current = 1.0f;
        }
        else if (yolos[index].GetCarData() >= 1)
        {
            deltaTime += 1.4f;
            test_deltaTime_current = 1.4f;
        }
        else // 차량이 없는 경우
        {
            deltaTime += 3.0f;
            test_deltaTime_current = 3.0f;
        }

        return deltaTime;
    }


    public float GetInternalTimer()
    {
        return test_deltaTime_current;
    }

    public void ResetInternalTimer()
    {
        internaltimer = 0;
    }

    public void IncreaseIndex()
    {
        if (index == 3)
        {
            index = 0;
        }
        else
        {
            index++;
        }
    }

    public void SpecialCarDetect()
    {
        for (int i = 0; i < yolos.Count; i++)
        {
            var special_car = yolos[i].GetSpecialCarData();
            if(special_car > 0)
                trafficLightManager.Emergency(i);
            
        }
        
    }

    
}
