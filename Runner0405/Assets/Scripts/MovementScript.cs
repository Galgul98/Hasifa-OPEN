using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float forwardSpeed = 1000; // זה כוח התזוזה קדימה
    public float sideSpeed = 500; //זה כוח התזוזה לצדדים
    public float jumpForce = 1000; // ..זה כוח תזוזה למעלה.. אני הוספתי
    Rigidbody rb; // זה קיצור לריג'ידבודי
    public int score;
    public GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //זה קישור לריג'ידבודי
    }

    
    void Update()
    {
        if (transform.position.y < -1) // מחפש את מיקום השחקן
        {
            gm.LostGame();
        }
        score = (int) Mathf.Round(transform.position.x * 100);
    }
    private void FixedUpdate() // אלה המקשים
    {
        rb.AddForce(forwardSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideSpeed * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }
    }
}
