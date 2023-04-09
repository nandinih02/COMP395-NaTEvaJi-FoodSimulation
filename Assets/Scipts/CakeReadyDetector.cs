using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CakeReadyDetector : MonoBehaviour
{
    private int finalScore;
    public GameObject FinalMenu;
    public TextMeshProUGUI finalText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pan"))
        {
            GameObject child = collision.gameObject.transform.GetChild(2).gameObject;    //get Cake gameobject
            if (child.activeSelf)
            {
                finalScore = ScoreStatic.score;
                if (finalScore > 600)
                {
                    finalText.text = "You've mastered it! Your score is " + finalScore.ToString();

                }
                else if (finalScore > 400)
                {
                    finalText.text = "Not bad! But you can make it better! Your score is " + finalScore.ToString();
                }
                else
                {
                    finalText.text =  "Your score is "+ finalScore.ToString() +". Try again!";
                }

                StartCoroutine(ShowEndScreen(5));
                              
            }
        }
    }


    IEnumerator ShowEndScreen(float delay)
    {       
        yield return new WaitForSeconds(delay);
        FinalMenu.SetActive(true);
    }
}
