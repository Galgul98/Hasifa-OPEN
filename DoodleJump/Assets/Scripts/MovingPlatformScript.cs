using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    bool movingPlatform;

    private void Update()
    {
        if (movingPlatform)
        {
            transform.position = new Vector3(transform.position.x + 0.03f, transform.position.y, transform.position.z);
            if (transform.position.x >= 2.9f)
            {
                movingPlatform = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, transform.position.z);
            if (transform.position.x <= -3.08f)
            {
                movingPlatform = true;
            }
        }
    }



}
