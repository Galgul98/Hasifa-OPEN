using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainWidget : MonoBehaviour
{
    public Text scoreText;
    public Text Coins;
    public Transform playerLocation;
    public MovementScript movementscript;
    public GameObject player;
    public GameObject startGame;
    public GameObject levelHolder;
    public GameObject selectLevelButten;
    
    void Start()
    {
        Coins.text = PlayerPrefs.GetInt("Coins").ToString();
        movementscript = FindObjectOfType<MovementScript>();
    }

    
    void Update()
    {
        scoreText.text = movementscript.score.ToString();// ����� ����� ������ ��� ����� �����
    }

    public void StartGame()// ����� ���� ������ �������� �� ����� �����
    {
        player.GetComponent<MovementScript>().enabled = true;
        startGame.SetActive(false);
        selectLevelButten.SetActive(false);
        Debug.Log("sadasdasd");
    }

    public void OpenLevelHolder()//����� ����� ������ ������ ������� ������ ����
    {
        if (levelHolder.activeSelf)
        {
            levelHolder.SetActive(false);
        }
        else levelHolder.SetActive(true);
    } 

    public void OpenLevel1()// ���� ��� ������ ������ �����
    {
        SceneManager.LoadScene(0);
    }
    public void OpenLevel2()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenLevel3()
    {
        SceneManager.LoadScene(2);
    }
}
