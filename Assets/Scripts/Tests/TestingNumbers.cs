using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingNumbers : MonoBehaviour
{
    public int number = -1;
    public TestingPAd padController;
    // Start is called before the first frame update
    void Start()
    {
        padController = FindObjectOfType<TestingPAd>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterTouch()
    {
        //Debug.Log(number);
        padController.AddNumber(number, this.GetComponent<Button>());
    }
}
