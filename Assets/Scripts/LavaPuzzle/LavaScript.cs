using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public Transform respawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.transform.position= respawn.position;
            other.transform.rotation = respawn.rotation;
        }
    }
}
