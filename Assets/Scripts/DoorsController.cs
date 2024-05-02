using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsController : MonoBehaviour
{
   // [SerializeField] GameObject nextDoor, entranceDoor;
    [SerializeField] GameObject entranceDoor, exitDoor, nextEntranceDoor;
    private AudioSource audioData;

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
        OpenNextDoor();
        StartCoroutine(OpenExitDoor());
    }
    
    public void StartRoom()
    {
        CloseEntranceDoor();
        //CloseExitDoor();
       // CloseNextDoor();
    }

   
    IEnumerator OpenExitDoor()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1.5f);
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
        entranceDoor.GetComponent<AudioSource>().Play();
    }
    private void OpenEntranceDoor()
    {
        entranceDoor.SetActive(true);
    }
}
