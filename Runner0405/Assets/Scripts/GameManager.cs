using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool lostGame = false;

    public void LostGame()//שורה של איפוס המשחק להתחלת השלם עם דיליי של 2 שניות
    {
        if (!lostGame)
        {
            lostGame = true;
            Invoke("ResetGame", 2f);
        }

    }
    void ResetGame()//שימרה של הניקוד אם תחילת השלב
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + FindObjectOfType<MovementScript>().score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
