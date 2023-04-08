using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject InstructionMenu;
    public GameObject InstructionButton;

    public void InstructionOpenFunction()
    {
        InstructionMenu.SetActive(true);
        InstructionButton.SetActive(false);
    }

    public void InstructionCloseFunction()
    {
        InstructionMenu.SetActive(false);
        InstructionButton.SetActive(true);
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        ScoreStatic.score = 0;
        SceneManager.LoadScene(scene.name);
        
    }

}
