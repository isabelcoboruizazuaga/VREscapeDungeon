using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadAreaController : MonoBehaviour
{
    [SerializeField] private GameObject rayController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rayController.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rayController.SetActive(true);
        }
    }
}
