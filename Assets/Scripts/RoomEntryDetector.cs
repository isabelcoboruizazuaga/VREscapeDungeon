using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEntryDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponentInParent<DoorsController>().StartRoom();
            Destroy(this.gameObject,0.5f);
        }
    }
}
