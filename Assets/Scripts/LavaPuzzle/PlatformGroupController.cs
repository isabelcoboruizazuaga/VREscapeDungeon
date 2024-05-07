using UnityEngine;

public class PlatformGroupController : MonoBehaviour
{

    public void RotateAll()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<PlatformHint>().RotatePlatform(1f);
            child.GetComponentInChildren<AudioSource>().Play();
            //child.GetComponent<AudioSource>().Play();
        }
    }
}
