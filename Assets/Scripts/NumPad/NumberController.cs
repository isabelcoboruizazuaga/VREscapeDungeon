using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public int number = -1;
    public NumberPadController padController;

    // Start is called before the first frame update
    void Start()
    {
        //padController=FindObjectOfType<NumberPadController>();
    }

    public void RegisterTouch()
    {           
        padController.AddNumber(number, this.GetComponent<Toggle>());
    }
}
