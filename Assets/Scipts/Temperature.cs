using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{
    public TextMeshProUGUI temperatura;
    private int tempAmount;
    // Start is called before the first frame update
    void Start()
    {
        tempAmount = 0;
       // temperatura = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        temperatura.text = tempAmount.ToString();
                
    }

    public void IncreaseTemperature()
    {
        if (tempAmount < 500)
        {
            tempAmount += 10;
        }
    }

    public void DecreaseTemperature()
    {
        if (tempAmount > 0)
        {
            tempAmount -= 10;
        }
    }
}