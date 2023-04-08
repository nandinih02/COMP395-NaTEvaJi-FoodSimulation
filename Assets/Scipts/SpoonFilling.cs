using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonFilling : MonoBehaviour
{    
   public int touch = 0;
    private GameObject child0;
    private void Start()
    {
        child0 = this.transform.GetChild(0).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vanilla"))
        {
            if (touch <= 2)
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
                    break;
                case 1:
                    child0.SetActive(true);
                    break;
                case 2:
                    child0.SetActive(true);
                    break;

                default:
                    child0.SetActive(false);                    
                    break;
            }

        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
