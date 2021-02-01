/* 
 * John Mordi
 * Ogre.cs
 * Assignment #1
 * Defines the actions and stats of an ogre enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : Enemy, Movement, Jumping
{
    private string name;

    public Ogre(string inName)
    {
        name = inName;
    }

    public override void Attack()
    {
        Debug.Log(name + " swings their club down to hit the hero.");
    }

    public void Jump()
    {
        Debug.Log(name + " jumps up and comes back to the ground with a thud.");
    }

    public void Run()
    {
        Debug.Log(name + " runs 3 feet forward.");
    }

    public void Walk()
    {
        Debug.Log(name + " walks 1 foot forward.");
    }
}
