using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower=20;
    public int score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal")*movementPower;
        Vector3 newMovement = rb.velocity;
        newMovement.x = horizontalMovement;
        rb.velocity = newMovement;
        int checkScore =Mathf.RoundToInt (transform.position.y * 100);
        if (checkScore > score)
            score = checkScore;
    }
}
