using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLevel : MonoBehaviour
{
    public GameObject endingAnimetion;
   
    private void OnTriggerEnter(Collider other)// מעלה את הקנבס של סוף השלב
    {
        Invoke("LoadNextLevel", 1);
        endingAnimetion.SetActive(true);
    }

    public void LoadNextLevel()// בסוף השלב כשמגיעים לסוף השלב מתחיל את השלב הבא
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
