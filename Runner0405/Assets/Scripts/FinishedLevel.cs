using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLevel : MonoBehaviour
{
    public GameObject endingAnimetion;
   
    private void OnTriggerEnter(Collider other)// ���� �� ����� �� ��� ����
    {
        Invoke("LoadNextLevel", 1);
        endingAnimetion.SetActive(true);
    }

    public void LoadNextLevel()// ���� ���� �������� ���� ���� ����� �� ���� ���
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
