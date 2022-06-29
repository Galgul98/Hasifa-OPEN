using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameManager gm;
    public MovementScript movementScript;
   
    
    private void OnCollisionEnter(Collision collision)//התנגשות בין הפלייר לאויבים
    {
        if (collision.transform.tag == "Enemy")
        {
            movementScript.enabled = false;
            gm.LostGame();
            gameObject.GetComponent<AudioSource>().Play();// סאונד של ההתנגשות
        }
    }
}
