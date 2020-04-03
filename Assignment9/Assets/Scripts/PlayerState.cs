using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * PlayerState.cs
 * Assignment 9
 * This is the interface for the methods in each state.
 */

public interface PlayerState
{
    void ChangeToBlue();
    void ChangeToYellow();
    void ChangeToRed();
}
