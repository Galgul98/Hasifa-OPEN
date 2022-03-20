using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollewer : MonoBehaviour
{
    public Transform playerTransform;
    private float offset;
    void Start()
    {
        offset = transform.position.y - playerTransform.position.y;

    }

    
    void Update()
    {
        float newYPosition = playerTransform.position.y - offset;
        if (newYPosition>transform.position.y)
        transform.position = new Vector3(transform.position.x,
            newYPosition, transform.position.z);
    }
}
