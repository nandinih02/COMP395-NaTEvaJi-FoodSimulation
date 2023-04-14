using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{
   private Slider slider;
    public float targetProgress = 0;
    public float fillSpeed = 0.5f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ImplementProgress(4.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (slider.value < targetProgress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        
    }

    public void ImplementProgress(float newProgress)
    {
       targetProgress = newProgress +slider.value;
    }
}
