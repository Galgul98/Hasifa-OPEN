using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour
{
    public GameObject lostCanves;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            FindObjectOfType<GameManager>().LostGame();
            other.GetComponent<PlayerMovement>().enabled = false;
            
        } Destroy(gameObject);

    }
  
    
}   

   
 
    
