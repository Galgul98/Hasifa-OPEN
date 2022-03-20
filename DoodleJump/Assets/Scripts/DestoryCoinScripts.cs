using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCoinScripts : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>()) 
        Destroy(gameObject);

        GameObject.Find("Player").GetComponent<PlayerMovement>().score += 1000;
    }
}
