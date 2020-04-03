using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * BlueState.cs
 * Assignment 9
 * This is one of the states the player can be in.
 */

public class BlueState : PlayerState
{
    PlayerStateClient playerStateClient;

    public BlueState(PlayerStateClient playerStateClient)
    {
        this.playerStateClient = playerStateClient;
    }

    public void ChangeToBlue()
    {
        Debug.Log("Change to Blue.");
        playerStateClient.currentState = playerStateClient.blueState;
    }

    public void ChangeToRed()
    {
        Debug.Log("Change to Red.");
        playerStateClient.currentState = playerStateClient.redState;
    }

    public void ChangeToYellow()
    {
        Debug.Log("Change to Yellow.");
        playerStateClient.currentState = playerStateClient.yellowState;
    }
}