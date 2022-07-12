using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeScaleChange : MonoBehaviour
{
    private int index;

    public TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        index = 1;
        tmp.text = "X1";
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TimeScaleto3X()
    {

        if (index == 0)
        {
            tmp.text = "X1";
            Time.timeScale = 1f;
            index++;
        }
        else if (index == 1)
        {
            tmp.text = "X2.5";
            Time.timeScale = 2.5f;
            index++;
        }
        else if (index == 2)
        {
            tmp.text = "X0";
            Time.timeScale = 0f;
            index = 0;
        }

        Time.fixedDeltaTime = 0.02f * Time.timeScale;

    }
}
