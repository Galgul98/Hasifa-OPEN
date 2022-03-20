using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayStats : MonoBehaviour
{
    public Text scoreText;
    public PlayerMovement PlayerMovement;
    public Text highScoreText;
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HS").ToString();
    }

    
    void Update()
    {
        scoreText.text = PlayerMovement.score.ToString();
    }
}
