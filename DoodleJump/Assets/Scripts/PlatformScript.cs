using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [Range(5,20)]
    public float jumpForce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                if (gameObject.GetComponent<BrokenPlat>())
                {
                    GetComponent<BrokenPlat>().BreakPlatform();
                }
            }
        }
    }
}
