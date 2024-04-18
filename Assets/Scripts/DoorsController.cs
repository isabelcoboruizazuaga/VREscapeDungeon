using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsController : MonoBehaviour
{
    [SerializeField] GameObject nextDoor, entranceDoor, leaveOpen;
    

    void Start()
    {
        if (entranceDoor != null)
        {
            CloseEntranceDoor();
        }
        if(nextDoor != null)
        {
            CloseNextDoor();
        }

        if (leaveOpen != null)
        {
            leaveOpen.SetActive(false);
        }
    }
    public void OpenNextDoor()
    {
        nextDoor.SetActive(false);
    }
    public void CloseNextDoor()
    {
        nextDoor.SetActive(true);
    }

    public void CloseEntranceDoor()
    {
        entranceDoor.SetActive(true);
    }
    public void OpenEntranceDoor()
    {
        entranceDoor.SetActive(true);
    }
}
