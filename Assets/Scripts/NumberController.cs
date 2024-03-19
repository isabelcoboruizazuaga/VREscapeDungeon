using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
       // padController.
    }
}
