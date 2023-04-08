using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlController : MonoBehaviour
{

    private GameObject glass, spoon;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Glass"))
        {
            glass = collision.gameObject;
            GameObject child0 = glass.transform.GetChild(0).gameObject;
            GameObject child1 = glass.transform.GetChild(1).gameObject;
            GameObject child2 = glass.transform.GetChild(2).gameObject;
            GameObject child3 = glass.transform.GetChild(3).gameObject;

            child0.SetActive(false);
            child1.SetActive(false);
            child2.SetActive(false);
            child3.SetActive(false);
            glass.GetComponent<GlassFilling>().touch = 0;

        }
        if (collision.gameObject.CompareTag("Spoon"))
        {
            spoon = collision.gameObject;
            GameObject child = spoon.transform.GetChild(0).gameObject;

            child.SetActive(false);
            spoon.GetComponent<SpoonFilling>().touch = 0;
        }


        }
        
}
