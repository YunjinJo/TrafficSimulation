using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TurnTheGameOn.SimpleTrafficSystem;
using UnityEngine;

public class ShowInputfield : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI greenText;
    [SerializeField] private TextMeshProUGUI yellowText;
    [SerializeField] private TextMeshProUGUI redText;

    [SerializeField] private TMP_InputField greenInputField;
    [SerializeField] private TMP_InputField yellowInputField;
    [SerializeField] private TMP_InputField redInputField;
    [SerializeField] private AITrafficLightManager trafficLightManager;

    private void Start()
    {
        ControlGameobjects(false);
    }

    public void DropdownMenuSelected(TMP_Dropdown selectedDropdown)
    {
        if (selectedDropdown.value != 0)
        {
            ControlGameobjects(true); // 드롭다운 메뉴 선택시 텍스트, inputfield 보임
            SetInpufieldText();
        }
        else
        {
            ControlGameobjects(false);
        }
        
        
    }

    private void ControlGameobjects(bool status)
    {
        greenText.gameObject.SetActive(status);
        yellowText.gameObject.SetActive(status);
        redText.gameObject.SetActive(status);
        
        greenInputField.gameObject.SetActive(status);
        yellowInputField.gameObject.SetActive(status);
        redInputField.gameObject.SetActive(status);
    }

    private void SetInpufieldText()
    {
        greenInputField.text = trafficLightManager.trafficLightCycles[trafficLightManager.selectedTrafficLight].greenTimer.ToString();
        yellowInputField.text = trafficLightManager.trafficLightCycles[trafficLightManager.selectedTrafficLight].yellowTimer.ToString();
        redInputField.text = trafficLightManager.trafficLightCycles[trafficLightManager.selectedTrafficLight].redtimer.ToString();
    }
}
