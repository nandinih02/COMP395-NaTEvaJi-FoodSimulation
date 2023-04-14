using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlController : MonoBehaviour
{
    public GameObject progressBar;

    private GameObject glass, spoon;
    public float sugarAmount=0f, flourAmount=0f, cocoaAmount = 0f, milkAmount = 0f, oilAmount = 0f, vanillaAmount = 0f;
    public int eggAmount = 0;
    public Toggle toggleSugar, toggleFlour,toggleCocoa, toggleMilk, toggleOil, toggleVanilla, toggleEgg;
    private bool scoreUp = false, scoreDown = false, flourScoreUp = false, flourScoreDown = false;
    private bool cocoaScoreUp = false, cocoaScoreDown = false, milkScoreUp = false, milkScoreDown = false;
    private bool oilScoreUp = false, oilScoreDown = false, eggScoreUp = false, eggScoreDown = false, vanillaScoreUp = false, vanillaScoreDown = false;
    // check mixing process
    private float progress;
    private float maxValue;
    private bool scoreAdded = false;

    private void Awake()
    {
       
     }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Glass"))
        {
            glass = collision.gameObject;
            //Sugar
            GameObject child0 = glass.transform.GetChild(0).gameObject;
            GameObject child1 = glass.transform.GetChild(1).gameObject;
            GameObject child2 = glass.transform.GetChild(2).gameObject;
            GameObject child3 = glass.transform.GetChild(3).gameObject;
            //Flour
            GameObject child4 = glass.transform.GetChild(4).gameObject;
            GameObject child5 = glass.transform.GetChild(5).gameObject;
            GameObject child6 = glass.transform.GetChild(6).gameObject;
            GameObject child7 = glass.transform.GetChild(7).gameObject;
            //Cocoa
            GameObject child8 = glass.transform.GetChild(8).gameObject;
            GameObject child9 = glass.transform.GetChild(9).gameObject;
            GameObject child10 = glass.transform.GetChild(10).gameObject;
            GameObject child11 = glass.transform.GetChild(11).gameObject;
            //Milk
            GameObject child12 = glass.transform.GetChild(12).gameObject;
            GameObject child13 = glass.transform.GetChild(13).gameObject;
            GameObject child14 = glass.transform.GetChild(14).gameObject;
            GameObject child15 = glass.transform.GetChild(15).gameObject;
            //Oil
            GameObject child16 = glass.transform.GetChild(16).gameObject;
            GameObject child17 = glass.transform.GetChild(17).gameObject;
            GameObject child18 = glass.transform.GetChild(18).gameObject;
            GameObject child19 = glass.transform.GetChild(19).gameObject;

            //Check Sugar
            if (child0.activeSelf)
            {
                print("Sugar 1/4");
                child0.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            if (child1.activeSelf)
            {
                print("Sugar 2/4");
                child1.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            if (child2.activeSelf)
            {
                print("Sugar 3/4");
                child2.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            if (child3.activeSelf)
            {
                print("Sugar 4/4");
                child3.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Sugar =" + sugarAmount);
            // Change Score
            if (sugarAmount >= 2)
            {
                toggleSugar.isOn = true;
                if (sugarAmount == 2)
                {
                    if (!scoreUp)
                    {
                        ScoreStatic.score += 50;
                        scoreUp = true;
                    }
                }
                else if (!scoreDown)
                {
                    ScoreStatic.score -= 20;
                    scoreDown = true;
                }
            }

            //Check Flour
            if (child4.activeSelf)
            {
                print("Flour 1/4");
                child4.SetActive(false);
                flourAmount += 1 / 4f;
            }
            if (child5.activeSelf)
            {
                print("Flour 2/4");
                child5.SetActive(false);
                flourAmount += 1 / 4f;
            }
            if (child6.activeSelf)
            {
                print("Flour 3/4");
                child6.SetActive(false);
                flourAmount += 1 / 4f;
            }
            if (child7.activeSelf)
            {
                print("Flour 4/4");
                child7.SetActive(false);
                flourAmount += 1 / 4f;
            }
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Flour =" + flourAmount);
            // Change Score
            if (flourAmount >= 1.75)
            {
                toggleFlour.isOn = true;
                if (flourAmount == 1.75)
                {
                    if (!flourScoreUp)
                    {
                        ScoreStatic.score += 50;
                        flourScoreUp = true;
                    }
                }
                else if (!flourScoreDown)
                {
                    ScoreStatic.score -= 20;
                    flourScoreDown = true;
                }
            }

            //Check Cocoa
            if (child8.activeSelf)
            {
                print("Cocoa 1/4");
                child8.SetActive(false);
                cocoaAmount += 1 / 4f;
            }
            if (child9.activeSelf)
            {
                print("Cocoa 2/4");
                child9.SetActive(false);
                cocoaAmount += 1 / 4f;
            }
            if (child10.activeSelf)
            {
                print("Cocoa 3/4");
                child10.SetActive(false);
                cocoaAmount += 1 / 4f;
            }
            if (child11.activeSelf)
            {
                print("Cocoa 4/4");
                child11.SetActive(false);
                cocoaAmount += 1 / 4f;
            }
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Cocoa =" + cocoaAmount);

            // Change Score
            if (cocoaAmount >= 0.75)
            {
                toggleCocoa.isOn = true;
                if (cocoaAmount == 0.75)
                {
                    if (!cocoaScoreUp)
                    {
                        ScoreStatic.score += 50;
                        cocoaScoreUp = true;
                    }
                }
                else if (!cocoaScoreDown)
                {
                    ScoreStatic.score -= 20;
                    cocoaScoreDown = true;
                }
            }


            //Check Milk
            if (child12.activeSelf)
            {
                print("Milk 1/4");
                child12.SetActive(false);
                milkAmount += 1 / 4f;
            }
            if (child13.activeSelf)
            {
                print("Milk 2/4");
                child13.SetActive(false);
                milkAmount += 1 / 4f;
            }
            if (child14.activeSelf)
            {
                print("Milk 3/4");
                child14.SetActive(false);
                milkAmount += 1 / 4f;
            }
            if (child15.activeSelf)
            {
                print("Milk 4/4");
                child15.SetActive(false);
                milkAmount += 1 / 4f;
            }
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Milk =" + milkAmount);

            // Change Score
            if (milkAmount >= 1.0)
            {
                toggleMilk.isOn = true;
                if (milkAmount == 1.0)
                {
                    if (!milkScoreUp)
                    {
                        ScoreStatic.score += 50;
                        milkScoreUp = true;
                    }
                }
                else if (!milkScoreDown)
                {
                    ScoreStatic.score -= 20;
                    milkScoreDown = true;
                }
            }

            //Check Oil
            if (child16.activeSelf)
            {
                print("Oil 1/4");
                child16.SetActive(false);
                oilAmount += 1 / 4f;
            }
            if (child17.activeSelf)
            {
                print("Oil 2/4");
                child17.SetActive(false);
                oilAmount += 1 / 4f;
            }
            if (child18.activeSelf)
            {
                print("Oil 3/4");
                child18.SetActive(false);
                oilAmount += 1 / 4f;
            }
            if (child19.activeSelf)
            {
                print("Oil 4/4");
                child19.SetActive(false);
                oilAmount += 1 / 4f;
            }
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Oil =" + oilAmount);
            if (oilAmount >= 0.5)
            {
                toggleOil.isOn = true;
            }

            // Change Score
            if (oilAmount >= 0.5)
            {
                toggleOil.isOn = true;
                if (oilAmount == 0.5)
                {
                    if (!oilScoreUp)
                    {
                        ScoreStatic.score += 50;
                        oilScoreUp = true;
                    }
                }
                else if (!oilScoreDown)
                {
                    ScoreStatic.score -= 20;
                    oilScoreDown = true;
                }
            }

        }

        //Check Eggs
        if (collision.gameObject.CompareTag("Egg"))
        {
            eggAmount += 1;
            print("Egg =" + eggAmount);
            if (eggAmount >= 2)
            {
                toggleEgg.isOn = true;
            }


            // Change Score
            if (eggAmount >= 2)
            {
                toggleEgg.isOn = true;
                if (eggAmount == 2)
                {
                    if (!eggScoreUp)
                    {
                        ScoreStatic.score += 50;
                        eggScoreUp = true;
                    }
                }
                else if (!eggScoreDown)
                {
                    ScoreStatic.score -= 20;
                    eggScoreDown = true;
                }
            }
            Destroy(collision.gameObject);
        }

        // Check Vanilla
        if (collision.gameObject.CompareTag("Spoon"))
        {
            spoon = collision.gameObject;
            GameObject child = spoon.transform.GetChild(0).gameObject;

            child.SetActive(false);
            vanillaAmount += 1 / 2f;
            print("Vanilla =" + vanillaAmount);

            // Change Score
            if (vanillaAmount >= 0.5f)
            {
                toggleVanilla.isOn = true;
                if (vanillaAmount == 0.5f)
                {
                    if (!vanillaScoreUp)
                    {
                        ScoreStatic.score += 50;
                        vanillaScoreUp = true;
                    }
                }
                else if (!vanillaScoreDown)
                {
                    ScoreStatic.score -= 20;
                    vanillaScoreDown = true;
                }
            }

            spoon.GetComponent<SpoonFilling>().touch = 0;
        }

        if (collision.gameObject.CompareTag("Mix"))
        {
            progressBar.SetActive(true);
            progressBar.GetComponent<ProgresBar>().fillSpeed = 0.5f;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mix"))
        {
            progress = progressBar.GetComponent<Slider>().value;
            maxValue = progressBar.GetComponent<Slider>().maxValue;
            print("progress: " + progress);
            print("maxValue: " + maxValue);
            if (progress < maxValue)
            {

                print("progress< maxValue: " );
                progressBar.GetComponent<ProgresBar>().fillSpeed =0f;

            }
            else
            {
                if (!scoreAdded)
                {
                 ScoreStatic.score += 40;
                    scoreAdded = true;
                    progressBar.SetActive(false);
                }
               
            }
        }
    }

}
