using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyObject : MonoBehaviour
{
    GameObject toggle;
    Toggle ingredients;
    private void Start()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.CompareTag("Sugar"))
        //{
        //    toggle = GameObject.FindGameObjectWithTag("Sugar");
        //    ingredients = toggle.GetComponent();


        //}

        if (collision.gameObject.CompareTag("Ingridient"))
        {
            Debug.Log("You Have added " + collision.gameObject.tag);
            Destroy(collision.gameObject);
        }
    }
}
