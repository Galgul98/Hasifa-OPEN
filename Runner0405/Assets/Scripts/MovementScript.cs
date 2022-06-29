using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float forwardSpeed = 1000; // �� ��� ������ �����
    public float sideSpeed = 500; //�� ��� ������ ������
    public float jumpForce = 1000; // ..�� ��� ����� �����.. ��� ������
    Rigidbody rb; // �� ����� ����'������
    public int score;
    public GameManager gm;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //�� ����� ����'������
    }

    
    void Update()
    {
        if (transform.position.y < -1) // ���� �� ����� �����
        {
            gm.LostGame();
        }
        score = (int) Mathf.Round(transform.position.x * 100);
    }
    private void FixedUpdate() // ��� ������
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
