using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderClimbController : MonoBehaviour
{
    public Rigidbody rb;
    public Collider _collider;

    public void DeactivateRb()
    {
        rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation ;
        _collider.enabled = false;
    }

    public void ActivateRb()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        _collider.enabled = true;
    }
}
