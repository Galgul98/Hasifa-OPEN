using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public bool currentlyMovingRight;
    [Range(0, 300)]
    public float movementSpeed;
    void Start()
    {
        movementSpeed = Random.Range(0.5f, 2);
        int i = Random.Range(0, 2);
        if (i == 0)
            currentlyMovingRight = false;
        else
            currentlyMovingRight = true;
    }

    
    void Update()
    {
        if (currentlyMovingRight)
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
            if (transform.position.x > 2.5f)
                currentlyMovingRight = !currentlyMovingRight;

        }
        else if (!currentlyMovingRight)
        {
            transform.position += new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
            if (transform.position.x < -3.09f)
                currentlyMovingRight = !currentlyMovingRight;
        }



    }
}
