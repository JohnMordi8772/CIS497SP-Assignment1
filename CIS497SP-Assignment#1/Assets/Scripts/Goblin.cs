/* 
 * John Mordi
 * Goblin.cs
 * Assignment #1
 * Defines the actions and stats of a goblin enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy, Movement, Jumping
{
    private string name;

    public Goblin(string inName)
    {
        name = inName;
    }

    public override void Attack()
    {
        Debug.Log(name + " lunges forward with a dagger to stab the hero.");
    }

    public void Jump()
    {
        Debug.Log(name + " jumps up and lands without a sound.");
    }

    public void Run()
    {
        Debug.Log(name + " runs 6 feet forward.");
    }

    public void Walk()
    {
        Debug.Log(name + " walks 2 feet forward.");
    }
}
