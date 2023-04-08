using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlController : MonoBehaviour
{
    
    private GameObject glass, spoon;
    public float sugarAmount=0f;
    public Toggle toggleSugar;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Glass"))
        {
            glass = collision.gameObject;
            GameObject child0 = glass.transform.GetChild(0).gameObject;
            GameObject child1 = glass.transform.GetChild(1).gameObject;
            GameObject child2 = glass.transform.GetChild(2).gameObject;
            GameObject child3 = glass.transform.GetChild(3).gameObject;







          //Check Sugar
            if (child0.activeSelf)
            {
                print("Sugar 1/4");
                child0.SetActive(false);
                sugarAmount += 1 / 4f;
            }

            if(child1.activeSelf)
            {
                print("Sugar 2/4");
                child1.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            if(child2.activeSelf)
            {
                print("Sugar 3/4");
                child2.SetActive(false);
                sugarAmount += 1 / 4f;
            }
            if(child3.activeSelf)
            {
                print("Sugar 4/4");
                child3.SetActive(false);
                sugarAmount += 1 / 4f;
            }
           
            glass.GetComponent<GlassFilling>().touch = 0;
            print("Sugar =" + sugarAmount);
            if (sugarAmount >= 2) 
            {
                toggleSugar.isOn = true;
            }
        }







        if (collision.gameObject.CompareTag("Spoon"))
        {
            spoon = collision.gameObject;
            GameObject child = spoon.transform.GetChild(0).gameObject;

            child.SetActive(false);
            spoon.GetComponent<SpoonFilling>().touch = 0;
        }


    }

    private void Update()
    {

    }

}
