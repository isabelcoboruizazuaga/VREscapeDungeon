using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomEntryDetector : MonoBehaviour
{
    public bool changeRay = false;
    public GameObject rayObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponentInParent<DoorsController>().StartRoom();
            if(changeRay)
            {
                changeXray();
            }
            Destroy(this.gameObject,0.5f);
        }
    }

    private void changeXray()
    {
        rayObject.GetComponent<XRRayInteractor>().maxRaycastDistance = 1.5f;
        rayObject.GetComponent<XRInteractorLineVisual>().lineLength = 1.5f;

    }
}
