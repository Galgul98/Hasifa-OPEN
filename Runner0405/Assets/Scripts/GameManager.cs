using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool lostGame = false;

    public void LostGame()//���� �� ����� ����� ������ ���� �� ����� �� 2 �����
    {
        if (!lostGame)
        {
            lostGame = true;
            Invoke("ResetGame", 2f);
        }

    }
    void ResetGame()//����� �� ������ �� ����� ����
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + FindObjectOfType<MovementScript>().score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
