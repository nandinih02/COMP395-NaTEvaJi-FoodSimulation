using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlCollision : MonoBehaviour
{
    
void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ingridient")
        {
            Debug.Log("Touching Other Ingredient");
        }
    }
}
