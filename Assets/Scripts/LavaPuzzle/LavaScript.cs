using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public Transform respawn;
    public GameObject platformController;

    private Transform platformTransform;

    private void Start()
    {
        platformTransform = platformController.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.transform.position= respawn.position;
            other.transform.rotation = respawn.rotation;
            other.GetComponent<Rigidbody>().useGravity = false;

            platformController.transform.position = platformTransform.position;
            platformController.transform.rotation = platformTransform.rotation;
        }
    }


}
