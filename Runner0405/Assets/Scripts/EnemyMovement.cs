using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    bool ememyMovement;
    // ������ �� ����� ��������
    private void Update()
    {
        if (ememyMovement)// ����� ��� ��� �� ����� �������� �������
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.07f);
            if (transform.position.z >= 3.15f)
            {
                ememyMovement = false;
            }
        }
        else//����� ���� ���� �� �� �����
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.07f);
            if (transform.position.z <= -3.15f)
            {
                ememyMovement = true;
            }
        }
    }
}
