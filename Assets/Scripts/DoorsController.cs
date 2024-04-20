using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsController : MonoBehaviour
{
   // [SerializeField] GameObject nextDoor, entranceDoor;
    [SerializeField] GameObject entranceDoor, exitDoor, nextEntranceDoor;

    void Start()
    {
        if (entranceDoor != null)
        {
           CloseEntranceDoor();
        }
        if(exitDoor != null)
        {
           CloseExitDoor();
        }
    }

    public void FinishRoom()
    {
        OpenExitDoor();
        OpenNextDoor();
    }
    
    public void StartRoom()
    {
        CloseEntranceDoor();
        //CloseExitDoor();
       // CloseNextDoor();
    }

    private void OpenExitDoor()
    {
        exitDoor.SetActive(false);
    }
    private void CloseExitDoor()
    {
        exitDoor.SetActive(true);
    }

    private void OpenNextDoor()
    {
        nextEntranceDoor.SetActive(false);
    }
    private void CloseNextDoor()
    {
        nextEntranceDoor.SetActive(true);
    }


    private void CloseEntranceDoor()
    {
        entranceDoor.SetActive(true);
    }
    private void OpenEntranceDoor()
    {
        entranceDoor.SetActive(true);
    }
}
