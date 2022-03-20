using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScripts : MonoBehaviour
{
    public GameObject lostCanves;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlatformScript>())
            Destroy(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            lostCanves.SetActive(true);
            int endScore = other.GetComponent<PlayerMovement>().score;
            if (endScore > PlayerPrefs.GetInt("HS"))
            {
                PlayerPrefs.SetInt("HS", endScore);
            }
        }
    }
    void Update()
    {
        
    }
}
