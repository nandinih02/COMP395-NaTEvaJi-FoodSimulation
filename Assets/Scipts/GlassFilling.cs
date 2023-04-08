using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFilling : MonoBehaviour
{
    //public GameObject glass;
   public int touch = 0;
    private GameObject child0, child1, child2, child3;   //Sugar
    private GameObject child4, child5, child6, child7;   //Flour
    private GameObject child8, child9, child10, child11;   //Cocoa
    private GameObject child12, child13, child14, child15;   //Milk
    private GameObject child16, child17, child18, child19;   //Oil

    private void Start()
    {
        child0 = this.transform.GetChild(0).gameObject;
        child1 = this.transform.GetChild(1).gameObject;
        child2 = this.transform.GetChild(2).gameObject;
        child3 = this.transform.GetChild(3).gameObject;
        child4 = this.transform.GetChild(4).gameObject;
        child5 = this.transform.GetChild(5).gameObject;
        child6 = this.transform.GetChild(6).gameObject;
        child7 = this.transform.GetChild(7).gameObject;
        child8 = this.transform.GetChild(8).gameObject;
        child9 = this.transform.GetChild(9).gameObject;
        child10 = this.transform.GetChild(10).gameObject;
        child11 = this.transform.GetChild(11).gameObject;
        child12 = this.transform.GetChild(12).gameObject;
        child13 = this.transform.GetChild(13).gameObject;
        child14 = this.transform.GetChild(14).gameObject;
        child15 = this.transform.GetChild(15).gameObject;
        child16 = this.transform.GetChild(16).gameObject;
        child17 = this.transform.GetChild(17).gameObject;
        child18 = this.transform.GetChild(18).gameObject;
        child19 = this.transform.GetChild(19).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {    //Sugar   
        if (collision.gameObject.CompareTag("Sugar"))
        {
            if (touch <= 4)
            {
                touch += 1;
            }
            else
            {
                touch = 0;
            }
            switch (touch)
            {
                case 0:
                    child0.SetActive(false);
                    child1.SetActive(false);
                    child2.SetActive(false);
                    child3.SetActive(false);
                    break;
                case 1:
                    child0.SetActive(true);
                    break;
                case 2:
                    child1.SetActive(true);
                    break;
                case 3:
                    child2.SetActive(true);
                    break;
                case 4:
                    child3.SetActive(true);
                    break;
                default:
                    child0.SetActive(false);
                    child1.SetActive(false);
                    child2.SetActive(false);
                    child3.SetActive(false);
                    break;
            }

        }
        //Flour
        if (collision.gameObject.CompareTag("Flour"))
        {
            if (touch <= 4)
            {
                touch += 1;
            }
            else
            {
                touch = 0;
            }
            switch (touch)
            {
                case 0:
                    child4.SetActive(false);
                    child5.SetActive(false);
                    child6.SetActive(false);
                    child7.SetActive(false);
                    break;
                case 1:
                    child4.SetActive(true);
                    break;
                case 2:
                    child5.SetActive(true);
                    break;
                case 3:
                    child6.SetActive(true);
                    break;
                case 4:
                    child7.SetActive(true);
                    break;
                default:
                    child4.SetActive(false);
                    child5.SetActive(false);
                    child6.SetActive(false);
                    child7.SetActive(false);
                    break;
            }

        }

        //Cocoa
        if (collision.gameObject.CompareTag("Cocoa"))
        {
            if (touch <= 4)
            {
                touch += 1;
            }
            else
            {
                touch = 0;
            }
            switch (touch)
            {
                case 0:
                    child8.SetActive(false);
                    child9.SetActive(false);
                    child10.SetActive(false);
                    child11.SetActive(false);
                    break;
                case 1:
                    child8.SetActive(true);
                    break;
                case 2:
                    child9.SetActive(true);
                    break;
                case 3:
                    child10.SetActive(true);
                    break;
                case 4:
                    child11.SetActive(true);
                    break;
                default:
                    child8.SetActive(false);
                    child9.SetActive(false);
                    child10.SetActive(false);
                    child11.SetActive(false);
                    break;
            }

        }
        //Milk
        if (collision.gameObject.CompareTag("Milk"))
        {
            if (touch <= 4)
            {
                touch += 1;
            }
            else
            {
                touch = 0;
            }
            switch (touch)
            {
                case 0:
                    child12.SetActive(false);
                    child13.SetActive(false);
                    child14.SetActive(false);
                    child15.SetActive(false);
                    break;
                case 1:
                    child12.SetActive(true);
                    break;
                case 2:
                    child13.SetActive(true);
                    break;
                case 3:
                    child14.SetActive(true);
                    break;
                case 4:
                    child15.SetActive(true);
                    break;
                default:
                    child12.SetActive(false);
                    child13.SetActive(false);
                    child14.SetActive(false);
                    child15.SetActive(false);
                    break;
            }

        }
        //Oil
        if (collision.gameObject.CompareTag("Oil"))
        {
            if (touch <= 4)
            {
                touch += 1;
            }
            else
            {
                touch = 0;
            }
            switch (touch)
            {
                case 0:
                    child16.SetActive(false);
                    child17.SetActive(false);
                    child18.SetActive(false);
                    child19.SetActive(false);
                    break;
                case 1:
                    child16.SetActive(true);
                    break;
                case 2:
                    child17.SetActive(true);
                    break;
                case 3:
                    child18.SetActive(true);
                    break;
                case 4:
                    child19.SetActive(true);
                    break;
                default:
                    child16.SetActive(false);
                    child17.SetActive(false);
                    child18.SetActive(false);
                    child19.SetActive(false);
                    break;
            }

        }











    }

  

    private void Update()
    {
        
    }
    
    
}
