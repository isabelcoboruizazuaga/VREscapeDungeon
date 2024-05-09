using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerBehaviour : MonoBehaviour
{
    private Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        buttons= gameObject.GetComponentsInChildren<Button>();
    }

    public void DeactivateButtons()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
    }

    public void ActivateButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }

    }
}
