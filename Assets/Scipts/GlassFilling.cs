using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFilling : MonoBehaviour
{
    //public GameObject glass;
   public int touch = 0;
    private GameObject child0, child1, child2, child3;
    private GameObject child4, child5, child6, child7;
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
    }

    private void OnCollisionEnter(Collision collision)
    {       
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

    }

  

    private void Update()
    {
        
    }
    
    
}
