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
        padController=FindObjectOfType<NumberPadController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RegisterTouch()
    {
        //Debug.Log(number);
            padController.AddNumber(number, this.GetComponent<Toggle>());
    }
}
