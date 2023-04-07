using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrambledEggRecipe : MonoBehaviour
{
    public GameObject egg;
    public GameObject milk;
    public GameObject whisk;
    public GameObject butter;
    public GameObject bowl;
    public GameObject fryingPan;

    public List<GameObject> recipeSteps; // list of GameObjects representing each step of the recipe
    public int currentStepIndex = 0; // index of the current step in the recipeSteps list

    public GameObject ScrambledEgg;
    public Vector3 spawnPosition = new Vector3(3.08f, 0.58f, -1.56f);

    /*void OnDestroy()
    {
        // Instantiate a new instance of the game object at the specified position
        
        Debug.Log("spawn!");
    }*/
    // Use this for initialization
    void Start()
    {
        egg = GameObject.Find("Egg");
        milk = GameObject.Find("Milk");
        whisk = GameObject.Find("Whisk");
        butter = GameObject.Find("Butter");
        bowl = GameObject.Find("Bowl");
        fryingPan = GameObject.Find("FryingPan");

       /* recipeSteps.Add(egg);
        recipeSteps.Add(whisk);
        recipeSteps.Add(butter);*/

        // activate the first step of the recipe
       // ActivateCurrentStep();
    }

    // Update is called once per frame
    void Update()
    {
        
        // check if the player has completed the current step
        if (currentStepComplete)
        {
                // the recipe is complete, do something here
                Debug.Log("Recipe complete!");
                Destroy(bowl);
            GameObject spawnedObject = Instantiate(ScrambledEgg, spawnPosition, Quaternion.identity);

        }
    }

    private bool currentStepComplete = false;

    private void OnCollisionEnter(Collision collision)
    {
      
        // Check if the collision is between the "egg" and "bowl" GameObjects.
        if (collision.gameObject.tag == "Egg")
        {
            // Set the current step as complete.
            Debug.Log("egg in bowl step");
            currentStepIndex++;
        }
        if (collision.gameObject.tag == "Milk")
        {
            // Set the current step as complete.
            Debug.Log("milk in bowl step");
            currentStepIndex++;
            
        }
        if (collision.gameObject.tag == "Whisk")
        {
            // Set the current step as complete.
            Debug.Log("whisk in bowl step");
            currentStepIndex++;

        }
        Debug.Log(currentStepIndex);
        if (currentStepIndex < recipeSteps.Count)
        {
            currentStepComplete = false;
        }
        else
        {
            currentStepComplete = true;
        }
    }

    void ActivateCurrentStep()
    {
        // deactivate all recipe steps
        foreach (GameObject step in recipeSteps)
        {
            step.SetActive(false);
        }
        // activate the current step
        recipeSteps[currentStepIndex].SetActive(true);
    }
}
