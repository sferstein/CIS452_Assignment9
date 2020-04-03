using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * YellowEnemy.cs
 * Assignment 9
 * This is one of the enemy scripts.
 */

public class YellowEnemy : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerStateClient playerStateClient;
    private float boundary = -15;
    public float speedInit;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerStateClient = GameObject.Find("Player").GetComponent<PlayerStateClient>();
    }

    public void Update()
    {
        if (transform.position.x < boundary)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.left * Time.deltaTime * speedInit);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && playerStateClient.currentState == playerStateClient.yellowState)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player") && playerStateClient.currentState != playerStateClient.yellowState)
        {
            gameManager.gameOver();
        }
    }
}
