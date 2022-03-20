using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawenrScrips : MonoBehaviour
{
    public Vector3 spawnPosition;
    public GameObject[] platforms;
    public Transform playerLocaition;

    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            CreatePlatform();
        }
    }


    void Update()
    {
        if (playerLocaition.position.y > spawnPosition.y - 15)
            CreatePlatform();
    }

    void CreatePlatform()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(5f,15f);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        int rando = Random.Range(0, platforms.Length);
        Instantiate(platforms[rando], spawnPosition, Quaternion.identity);
    }
}
