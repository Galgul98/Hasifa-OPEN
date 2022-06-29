using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    bool ememyMovement;
    // סקריפט של תזוזת המחשולים
    private void Update()
    {
        if (ememyMovement)// תזוזה לצד אחד עד הגבלה שמצויינת בסקריפט
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.07f);
            if (transform.position.z >= 3.15f)
            {
                ememyMovement = false;
            }
        }
        else//תזוזה לצעד השני גם עם הגבלה
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.07f);
            if (transform.position.z <= -3.15f)
            {
                ememyMovement = true;
            }
        }
    }
}
