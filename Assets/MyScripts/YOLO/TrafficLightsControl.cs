using System.Collections;
using System.Collections.Generic;
using TurnTheGameOn.SimpleTrafficSystem;
using UnityEngine;

public class TrafficLightsControl : MonoBehaviour
{
    [Tooltip("Array of AITrafficLightCycles played as a looped sequence.")]
        public AITrafficLightCycle[] trafficLightCycles;
        private float timer;
        public enum CycleState { Green, Red, Yellow, Complete }
        public CycleState lightState;
        public int cycleIndex;
        
        
        public CountTriggerManager _timer;
        private float _ex_timer;
        public float test_timer;
        public TrafficAlgorithm algorithm;

        private void Start()
        {
            if (trafficLightCycles.Length > 0)
            {
                // Set all lights to red
                for (int i = 0; i < trafficLightCycles.Length; i++)
                {
                    for (int j = 0; j < trafficLightCycles[i].trafficLights.Length; j++)
                    {
                        trafficLightCycles[i].trafficLights[j].EnableRedLight();
                    }
                }
                lightState = CycleState.Red;
                cycleIndex = -1;
                timer = 0.0f;
            }
            else
            {
                Debug.LogWarning("There are no lights assigned to this TrafficLightManger, it will be disabled.");
                enabled = false;
            }

            _ex_timer = 0;
        }

        private void FixedUpdate()
        {
            if (!(_timer.timerCount - _ex_timer > 1)) return;
            _ex_timer = _timer.timerCount;
            if (timer > 0.0f)
            {
                timer -= algorithm.GetInternalTimer();
                test_timer = timer;
            }
            else
            {
                if (lightState == CycleState.Complete)
                {
                    lightState = CycleState.Green;
                    algorithm.ResetInternalTimer();
                    algorithm.IncreaseIndex();
                    timer = trafficLightCycles[cycleIndex].greenTimer;
                    for (int i = 0; i < trafficLightCycles[cycleIndex].trafficLights.Length; i++)
                    {
                        trafficLightCycles[cycleIndex].trafficLights[i].EnableGreenLight();
                    }
                }
                else if (lightState == CycleState.Green)
                {
                    lightState = CycleState.Yellow;
                    algorithm.ResetInternalTimer();
                    
                    timer = trafficLightCycles[cycleIndex].yellowTimer;
                    for (int i = 0; i < trafficLightCycles[cycleIndex].trafficLights.Length; i++)
                    {
                        trafficLightCycles[cycleIndex].trafficLights[i].EnableYellowLight();
                    }
                }
                else if (lightState == CycleState.Yellow)
                {
                    lightState = CycleState.Red;
                    algorithm.ResetInternalTimer();
                    
                    timer = trafficLightCycles[cycleIndex].redtimer;
                    for (int i = 0; i < trafficLightCycles[cycleIndex].trafficLights.Length; i++)
                    {
                        trafficLightCycles[cycleIndex].trafficLights[i].EnableRedLight();
                    }
                }
                else if (lightState == CycleState.Red)
                {
                    lightState = CycleState.Complete;
                    algorithm.ResetInternalTimer();
                    
                    cycleIndex = cycleIndex != trafficLightCycles.Length - 1 ? cycleIndex + 1 : 0;
                }
            }


        }
}
