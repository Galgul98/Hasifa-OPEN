using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScripts : MonoBehaviour
{
    //חיבור בין השחקן למצלמה
    public Transform playerPosition;
    private Vector3 offSet;
    void Start()
    {
        offSet = playerPosition.position - transform.position;
    }


    void Update()
    {
        transform.position = playerPosition.position - offSet;
    }
}
