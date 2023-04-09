using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OvenController : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    private bool scoreUp = false, scoreDown = false;
    public GameObject timer;
   // public GameObject pan;
    private float startTime, endTime, bakingTime ;
    private int tempAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pan"))
        {
            StartCoroutine(ShowMessage("Pan is in the oven", 2));
           
            tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            int ingridientCount = collision.gameObject.GetComponent<PanController>().ingridientCount;
            if (ingridientCount == 0)
            {
                StartCoroutine(ShowMessage("The backing pan is empty!", 2));
            }
            else
            {
                if (tempAmount < 250)
                {
                    StartCoroutine(ShowMessage("Set the temperature!", 2));
                }
                else
                {
                    StartCoroutine(ShowMessage("Start baking", 2));
                    startTime = timer.GetComponent<Timer>().timeValue;
                }

                if (tempAmount == 350 && !scoreUp)
                {
                    ScoreStatic.score += 50;
                    scoreUp = true;
                }
                else if (tempAmount >= 400 && !scoreDown)
                {
                    ScoreStatic.score -= 100;
                    scoreDown = true;
                }
            }
        }


        if (collision.gameObject.CompareTag("Bowl"))
        {
            StartCoroutine(ShowMessage("Cautions!!! Bowl is in the oven!", 2));
           // print("Cautions!!! Bowl in the oven");
             tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            if (tempAmount >0)
            {
                ScoreStatic.score -= 200;
            }
        }   
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pan"))
        {
            int ingridientCount = collision.gameObject.GetComponent<PanController>().ingridientCount;
            if (ingridientCount >0)
            {                
                endTime = timer.GetComponent<Timer>().timeValue;
                bakingTime = Mathf.FloorToInt((endTime - startTime) % 60); //time in sec
                print("Baking time" + bakingTime);
                if (bakingTime < 20)
                {
                    ScoreStatic.score -= 50;
                    StartCoroutine(ShowMessage("The dough is not baked", 2));
                }
                else if (bakingTime > 25)
                {
                    ScoreStatic.score -= 50;
                    StartCoroutine(ShowMessage("The cake is burnt", 2));
                    GameObject child = collision.gameObject.transform.GetChild(2).gameObject;    //get Cake gameobject
                    child.SetActive(true);
                }
                else
                {
                    ScoreStatic.score += 50;
                    StartCoroutine(ShowMessage("The cake is perfectly baked", 2));
                    GameObject child = collision.gameObject.transform.GetChild(2).gameObject;    //get Cake gameobject
                    child.SetActive(true);
                }
            }
        }
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        messageText.text = message;
        messageText.enabled = true;
        yield return new WaitForSeconds(delay);
        messageText.enabled = false;
    }
}
