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
    public int select;

    private void Start()
    {
        ControlGameobjects(false);
        select = 0;
    }

    public void DropdownMenuSelected(TMP_Dropdown selectedDropdown)
    {
        select = selectedDropdown.value + 1;
        if (selectedDropdown.value != 0)
        {
            ControlGameobjects(true); // 드롭다운 메뉴 선택시 텍스트, inputfield 보임
            SetInpufieldText(selectedDropdown.value - 1);
        }
        else
        {
            ControlGameobjects(false);
        }
        
        
    }

    public void EditTrafficLightTimer(TMP_InputField textInput)
    {
        if (textInput.text != null && textInput.name == "Green")
            trafficLightManager.trafficLightCycles[@select].greenTimer = float.Parse(textInput.text);
        else if (textInput.text != null && textInput.name == "Yellow")
            trafficLightManager.trafficLightCycles[@select].yellowTimer = float.Parse(textInput.text);
        else if (textInput.text != null && textInput.name == "Red")
            trafficLightManager.trafficLightCycles[@select].redtimer = float.Parse(textInput.text);
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

    private void SetInpufieldText(int selectedDropdown)
    {
        greenInputField.text = trafficLightManager.trafficLightCycles[selectedDropdown].greenTimer.ToString();
        yellowInputField.text = trafficLightManager.trafficLightCycles[selectedDropdown].yellowTimer.ToString();
        redInputField.text = trafficLightManager.trafficLightCycles[selectedDropdown].redtimer.ToString();
    }
}
