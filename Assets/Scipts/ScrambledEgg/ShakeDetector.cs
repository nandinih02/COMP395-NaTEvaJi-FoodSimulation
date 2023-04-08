using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ShakeDetector : MonoBehaviour
{
    public float movementThreshold = 0.1f;
    public int horizontalMovementCount = 3;
    public GameObject scrambledEggPrefab;
    private int currentHorizontalMovementCount = 0;
    private Vector3 previousPosition;
    //public CompleteMessage recipeComplete;
    private TextMeshProUGUI completeMessage;
    private bool isMixDone = false;
    private bool eggScrambled = false;

    void Start()
    {
        completeMessage = GameObject.Find("CompleteMessage").GetComponent<TextMeshProUGUI>();
        completeMessage.enabled = false;
        previousPosition = transform.position;
    }

    void Update()
    {
        float movementDelta = Mathf.Abs(transform.position.x - previousPosition.x);

        if (movementDelta > movementThreshold && isMixDone)
        {
            currentHorizontalMovementCount++;
            previousPosition = transform.position;
        }

        if (currentHorizontalMovementCount == horizontalMovementCount)
        {
            if (!eggScrambled)
            {
                //Instantiate(scrambledEggPrefab, transform.position, Quaternion.identity);
                Instantiate(scrambledEggPrefab, transform.position + new Vector3(0, 1.3f, 0), Quaternion.identity);
                eggScrambled = true;
               
            }

            //  recipeComplete.DisplayMessage();
            
            // currentHorizontalMovementCount = 0;
        }
        if (eggScrambled)
        {
            Invoke("ShowMessage", 3f);
        }
  
    }
    void ShowMessage()
    {
        // Show the "completeMessage" text
        completeMessage.enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bowl" && ScrambledEggRecipe.currentStepComplete)
        {
            // Set the current step as complete.
           
            isMixDone = true;
            Debug.Log("mix is done");
        }
    }
}
