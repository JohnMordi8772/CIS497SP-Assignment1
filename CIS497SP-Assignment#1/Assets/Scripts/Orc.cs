/* 
 * John Mordi
 * Orc.cs
 * Assignment #1
 * Defines the actions and stats of an orc enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy, Movement, Jumping
{
    private string name;

    public Orc(string inName)
    {
        name = inName;
    }

    public override void Attack()
    {
        Debug.Log(name + " swings their axe at the hero.");
    }

    public void Jump()
    {
        Debug.Log(name + " jumps up into the air and lands with a slight thud.");
    }

    public void Run()
    {
        Debug.Log(name + " runs 4.5 feet forward.");
    }

    public void Walk()
    {
        Debug.Log(name + " walks 1.5 feet forward.");
    }
}
