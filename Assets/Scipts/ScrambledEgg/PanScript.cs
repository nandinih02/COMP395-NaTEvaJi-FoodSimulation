using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScript : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(ScrambledEggRecipe.currentStepComplete);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScrambledEggRecipe.currentStepComplete)
        {
            // the recipe is complete, do something here
            Debug.Log("pan");

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bowl" && ScrambledEggRecipe.currentStepComplete)
        {
            // Set the current step as complete.
            Debug.Log("bowl in pan");
        }
    }

    }
