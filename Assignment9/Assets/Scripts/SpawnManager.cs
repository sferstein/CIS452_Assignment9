using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SpawnManager.cs
 * Assignment 9
 * This manages the enemies that spawn.
 */

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private GameManager gameManager;
    private float spawnPosX = 15;
    private float delay = 0.5f;
    private float spawnPosZ = -5;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", delay, spawnInterval);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void spawnEnemy()
    {
        if (gameManager.isGameActive)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
            int wallIndex = Random.Range(0, enemyPrefab.Length);

            Instantiate(enemyPrefab[wallIndex], spawnPos,
                enemyPrefab[wallIndex].transform.rotation);
        }
    }
}
