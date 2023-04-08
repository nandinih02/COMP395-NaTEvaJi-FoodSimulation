using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanController : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    private bool scoreUp = false, scoreDown = false;
    private int ingridientCount = 0;
    private bool floured = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bowl"))
        {
            GameObject bowl = collision.gameObject;
            Toggle sugar = bowl.GetComponent<BowlController>().toggleSugar;
            Toggle flour = bowl.GetComponent<BowlController>().toggleFlour;
            Toggle cocoa = bowl.GetComponent<BowlController>().toggleCocoa;
            Toggle egg = bowl.GetComponent<BowlController>().toggleEgg;
            Toggle milk = bowl.GetComponent<BowlController>().toggleMilk;
            Toggle oil = bowl.GetComponent<BowlController>().toggleOil;
            Toggle vanilla = bowl.GetComponent<BowlController>().toggleVanilla;


            if (sugar.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (flour.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (cocoa.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (egg.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (milk.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (oil.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }
            if (vanilla.isOn)
            {
                ScoreStatic.score += 20;
                ++ingridientCount;
            }



            if (ingridientCount > 0)
            {
                StartCoroutine(ShowMessage("Dough is in the pan", 1));
                if (ingridientCount < 7)
                {
                    StartCoroutine(ShowMessage("You lack some ingridients", 1));
                }
            }
            else
            {
                StartCoroutine(ShowMessage("Bowl is empty", 2));
            }

        }

        if (collision.gameObject.CompareTag("Butter"))
        {
            ScoreStatic.score += 20;
            StartCoroutine(ShowMessage("Well done! You've greased baking pan", 2));
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Flour"))
        {
            if (!floured)
            {
                ScoreStatic.score += 20;
                StartCoroutine(ShowMessage("Well done! You've floured baking pan", 2));
                floured = true;
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

