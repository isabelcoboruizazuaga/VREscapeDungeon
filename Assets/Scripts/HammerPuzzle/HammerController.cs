using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Hammer"))
        {
            other.gameObject.GetComponentInChildren<BoxBreak>().Break();

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
