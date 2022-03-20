using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform characterLocation;
    public GameObject platformPrefab;
    public GameObject movingPlatform;
    public GameObject breakingPlatform;
    public GameObject enemy;
    public GameObject lostCanvas;
    public GameObject player;
    public Vector3 lastSpawnPosition;
    public Vector3 lastSpawnPositionEnem;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            SpawnPlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (characterLocation.position.y > lastSpawnPosition.y - 15)
            SpawnPlatform();
        if (characterLocation.position.y > lastSpawnPositionEnem.y - 15)
            SpawnEnemy();
        if (characterLocation.position.y < 10)
            difficulty = 0;
        else if (characterLocation.position.y < 20)
            difficulty = 1;
        else if (characterLocation.position.y < 30)
            difficulty = 2;
        else
            difficulty = 3;

    }
    void SpawnPlatform()
    {
        if (difficulty == 0)
        {
            lastSpawnPosition.y += Random.Range(0.5f, 2);
            lastSpawnPosition.x = Random.Range(-3.05f, 2.5f);
            Instantiate(platformPrefab, lastSpawnPosition, Quaternion.identity);
        }
        if (difficulty == 1)
        {
            lastSpawnPosition.y += Random.Range(0.6f, 2.1f);
            lastSpawnPosition.x = Random.Range(-3.05f, 2.5f);

            float i = Random.Range(0, 100);

            if (i < 80)
                Instantiate(platformPrefab, lastSpawnPosition, Quaternion.identity);
            else
                Instantiate(breakingPlatform, lastSpawnPosition, Quaternion.identity);

        }
        if (difficulty == 2)
        {
            lastSpawnPosition.y += Random.Range(0.5f, 2);
            lastSpawnPosition.x = Random.Range(-3.05f, 2.5f);

            float i = Random.Range(0, 100);

            if (i < 40)
                Instantiate(platformPrefab, lastSpawnPosition, Quaternion.identity);
            else if (i>40&&i<70)
                Instantiate(movingPlatform, lastSpawnPosition, Quaternion.identity);
            else
                Instantiate(breakingPlatform, lastSpawnPosition, Quaternion.identity);

        }
        if (difficulty == 3)
        {
            lastSpawnPosition.y += Random.Range(0.5f, 2);
            lastSpawnPosition.x = Random.Range(-3.05f, 2.5f);
            Instantiate(movingPlatform, lastSpawnPosition, Quaternion.identity);
        }



    }
    void SpawnEnemy()
    {
        lastSpawnPositionEnem.y += Random.Range(5, 15);
        lastSpawnPositionEnem.x = Random.Range(-3.05f, 2.5f);
        Instantiate(enemy, lastSpawnPositionEnem, Quaternion.identity);

    }
    public void LostGame()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody>().isKinematic = true;
        lostCanvas.SetActive(true);
    }
}
