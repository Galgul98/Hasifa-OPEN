using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostCanvasScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void Update()
    {
        
    }
}
