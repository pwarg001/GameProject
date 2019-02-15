using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCube : MonoBehaviour
{
    public float pushPower = 5.0f;
     
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y < 0.3f)
        {
            return;
        }

    }
}
