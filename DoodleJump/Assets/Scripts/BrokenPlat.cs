using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenPlat : MonoBehaviour
{
    public GameObject leftCube;
    public GameObject rightCube;

   
    void Start()
    {

    }

    void Update()
    {

    }
    public void BreakPlatform()
    {
        Rigidbody leftRB = leftCube.GetComponent<Rigidbody>();
        Rigidbody rightRB = rightCube.GetComponent<Rigidbody>();
        leftRB.isKinematic = false;
        rightRB.isKinematic = false;
        leftRB.useGravity = true;
        rightRB.useGravity = true;
        leftRB.AddForce(-15, 0, 0);
        rightRB.AddForce(15, 0, 0);


    }
}
