using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCountRecord : MonoBehaviour
{
    public CountTriggerManager countTriggerManager;

    public CarCount carCount;

    public List<int> carCountList = new List<int>();
    public int i;
    [SerializeField]
    private TextMeshProUGUI textMeshPro;

    public SaveCSV saveCsv;

    public string texts;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(countTriggerManager.timerCount - (60f * (i+1))) < 0.5)
        {
            carCountList.Add(countTriggerManager.carCount);
            texts = (carCountList[i].ToString());
            

            textMeshPro.text = "Record: " + texts;
            i++;
        }
    }

    public void SaveData()
    {
        var scene = SceneManager.GetActiveScene().name;
        if (scene == "Demo_AI 1")
        {
            saveCsv.WriteData_AI(carCountList);
        }
            
        else
        {
            saveCsv.WriteData(carCountList);
        }
        
    }
    
}
