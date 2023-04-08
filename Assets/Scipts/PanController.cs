using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanController : MonoBehaviour
{
    private bool scoreUp = false, scoreDown = false;

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

            print("Dough in the pan");
            
            if (!scoreUp)
            {
                if (sugar.isOn)
                {
                    ScoreStatic.score += 20;                   
                }
                if (flour.isOn)
                {
                    ScoreStatic.score += 20;
                }
                if (cocoa.isOn)
                {
                    ScoreStatic.score += 20;
                }
                if (egg.isOn)
                {
                    ScoreStatic.score += 20;
                }
                if (milk.isOn)
                {
                    ScoreStatic.score += 20;
                }
                if (oil.isOn)
                {
                    ScoreStatic.score += 20;
                }
                if (vanilla.isOn)
                {
                    ScoreStatic.score += 20;
                }
                
                scoreUp = true;
            }
          
        }
    }
 }

