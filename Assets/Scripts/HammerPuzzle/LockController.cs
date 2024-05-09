using UnityEngine;

public class LockController : MonoBehaviour
{
    public string roomName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lock")){
            GameObject.Find(roomName).GetComponent<DoorsController>().FinishRoom();
        }

    }

}
