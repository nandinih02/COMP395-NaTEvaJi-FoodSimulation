using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OvenController : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    private bool scoreUp = false, scoreDown = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pan"))
        {
            StartCoroutine(ShowMessage("Pan in the oven", 2));
           
            int tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            if (tempAmount == 350 && !scoreUp)
            {
                ScoreStatic.score += 50;
                scoreUp = true;
            }
            else if(tempAmount >= 400 && !scoreDown)
            { 
                ScoreStatic.score -= 100;
                scoreDown = true;
            }
            
        }


        if (collision.gameObject.CompareTag("Bowl"))
        {
            StartCoroutine(ShowMessage("Cautions!!! Bowl in the oven!", 2));
           // print("Cautions!!! Bowl in the oven");
            int tempAmount = this.gameObject.GetComponent<Temperature>().tempAmount;
            if (tempAmount >0)
            {
                ScoreStatic.score -= 200;
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
}
