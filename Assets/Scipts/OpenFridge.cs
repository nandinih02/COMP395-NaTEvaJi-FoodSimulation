using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenFridge : MonoBehaviour
{
   
    Vector3 pos;
    Quaternion rot;
    Vector3 curEulAng;
    float y;
    float count = 0;
    //timer variables
    private float openedTime=0f;
    private bool isOpened=false, messageShown;

    public TextMeshProUGUI messageText;


    void Start()
    {
        pos = transform.localPosition;
    }

     void Update()
    {
       openedTime += Time.deltaTime;
        if (isOpened)
        {
            if (openedTime > 15)
            {
                DecreaseScore();
            }
            else if (openedTime > 10 && !messageShown)
            {
                StartCoroutine(ShowMessage("Don't leave the fridge door open for too long!", 3f));
            }
        }
       
    }
    private void OnMouseDown()
    {
        count += 1;
        if (count == 1)
        {
            openedTime = 0;
            pos.z += 0.67f;
            pos.x -= 0.35f;
            y = -90f;
            curEulAng += new Vector3(0, y, 0);
            rot.eulerAngles = curEulAng;
            transform.localPosition = pos;
            transform.localRotation = rot;
            isOpened = true;
            messageShown = false;


        }
        else if (count == 2)
        {
            pos.z -= 0.67f;
            pos.x += 0.35f;
            y = 90f;
            curEulAng += new Vector3(0, y, 0);
            rot.eulerAngles = curEulAng;
            transform.localPosition = pos;
            transform.localRotation = rot;
            count = 0;
            isOpened = false;
            openedTime = 0;
        }

    }

    IEnumerator ShowMessage(string message, float delay)
    {

        messageText.text = message;
        messageText.enabled = true;
        yield return new WaitForSeconds(delay);
        messageText.enabled = false;
        messageShown = true; ;
    }

    private void DecreaseScore()
    {
        ScoreStatic.score -= 20;
        isOpened = false;
    }


}
