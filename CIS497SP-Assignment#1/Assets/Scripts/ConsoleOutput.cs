/* 
 * John Mordi
 * ConsoleOutput.cs
 * Assignment #1
 * Creates lists of the various character types and executes some of their actions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Enemy> classList = new List<Enemy>();

    public List<Jumping> interfaceList = new List<Jumping>();

    // Start is called before the first frame update
    void Start()
    {
        classList.Add(new Goblin("Skarsnik"));
        classList.Add(new Goblin("Grom"));
        classList.Add(new Ogre("Grob"));
        classList.Add(new Ogre("Tor"));
        classList.Add(new Orc("Grimgor"));

        interfaceList.Add(new Goblin("Kibo"));
        interfaceList.Add(new Goblin("Limbin"));
        interfaceList.Add(new Ogre("Rok"));
        interfaceList.Add(new Ogre("Bulk"));
        interfaceList.Add(new Orc("Wurrzag"));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Enemy t in classList)
            {
                t.Attack();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(Jumping t in interfaceList)
            {
                t.Jump();
            }
        }
    }
}
