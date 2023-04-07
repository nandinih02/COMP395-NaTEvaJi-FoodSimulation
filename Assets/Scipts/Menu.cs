using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
