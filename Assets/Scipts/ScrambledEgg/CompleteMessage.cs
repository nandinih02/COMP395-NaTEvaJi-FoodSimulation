using UnityEngine;
using UnityEngine.UI;

public class CompleteMessage : MonoBehaviour
{
    public float displayTime = 3f; // Time to display message in seconds
    private Text messageText;
    private bool isDisplayingMessage = false;

    void Start()
    {
        messageText = GetComponent<Text>();
        messageText.enabled = false;
    }

    public void DisplayMessage()
    {
        if (!isDisplayingMessage)
        {
            isDisplayingMessage = true;
            messageText.enabled = true;
            messageText.text = "Recipe complete";
            Invoke("HideMessage", displayTime);
        }
    }

    private void HideMessage()
    {
        messageText.enabled = false;
        isDisplayingMessage = false;
    }
}
