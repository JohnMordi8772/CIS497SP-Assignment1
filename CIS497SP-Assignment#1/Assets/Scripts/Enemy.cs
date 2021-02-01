/* 
 * John Mordi
 * Enemy.cs
 * Assignment #1
 * Provides a framework of necessary methods for enemy characters
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
    private int health = 10;
    public abstract void Attack();
}
