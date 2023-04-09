using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    public float timeSpeed = 1.0f;
    public TextMeshProUGUI timerText;
    public float timeValue = 0f;
   

    // Update is called once per frame
    void Update()
    {
        timeValue += Time.deltaTime;
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay*timeSpeed / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay*timeSpeed %60);
        timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }


}
