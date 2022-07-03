using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarCount : MonoBehaviour
{
    public CountTriggerManager countTriggerManager;
    
    [SerializeField]
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "CarCount: " + countTriggerManager.carCount;
    }
}
