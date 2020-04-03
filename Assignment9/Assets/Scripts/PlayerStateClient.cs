using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * PlayerStateClient.cs
 * Assignment 9
 * This is the client that controls which state the player is in.
 */

public class PlayerStateClient : MonoBehaviour
{
    public PlayerState redState { get; set; }
    public PlayerState yellowState { get; set; }
    public PlayerState blueState { get; set; }
    public PlayerState currentState { get; set; }

    void Start()
    {
        redState = new RedState(this);
        blueState = new BlueState(this);
        yellowState = new YellowState(this);

        currentState = yellowState;
    }

    public void ChangeToBlue() { currentState.ChangeToBlue(); }
    public void ChangeToYellow() { currentState.ChangeToYellow(); }
    public void ChangeToRed() { currentState.ChangeToRed(); }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Current state: " + currentState);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeToBlue();
            GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeToRed();
            GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeToYellow();
            GetComponent<Renderer>().material.color = new Color(255, 255, 0);
        }
    }
}
