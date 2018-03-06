/*  Code by:    Will Wallace
 *  Student ID: 200265595
 *  CTCH 310 - Winter 2018
 *  Lab 4
 *  This code uses two separate switch statements to perform A.I. actions:
 *      1.  Display a greeting based on the monster's IQ level.
 *      2.  Follow the player if the player comes too close, and increase the size of the monster as it approaches.
 *          (The player's position is given by designating the player object as the monster's target in the Inspector console.)
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversation : MonoBehaviour
{
    int action = 0; //this will be used to control void Chase and determine which switch case to use
    float increment = 0.05f;  //this measures how big of a step the bunny takes toward the player, i.e. its speed
    public Transform targetPlayer; //this is the player, whom our bunny will follow

    private void FixedUpdate()
    {
        //check to see if the player is within a certain distance of our bunny
        if (Vector3.Distance(targetPlayer.position, transform.position) < 5)
        {
            action = 1;
            print("You are within 5 units of the bunny.  He will now follow you...");
        }

        //if the player allows the monster to get REALLY close
        if (Vector3.Distance(targetPlayer.position, transform.position) < 0.5)
        {
            action = 2;
        }
            
        Chase();
    }

    private void Start()
    {
        Greet();
    }

    //there are 2 different modes of chasing the monster may enact
    void Chase()
    {
        switch(action)
        {
            case 1:
                //standard following
                transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, increment);
                break;

            case 2:
                {
                    //monster continues to follow AND grows incrementally larger to potentially hilarious proportions
                    transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, increment);
                    transform.localScale = new Vector3(50f, 50f, 50f);
                    break;
                }

            default:
                break;
        }
    }

    //the monster will greet the player with various greetings depending on its IQ level
    public int iq = 5;

    void Greet()
    {
        switch (iq)
        {
            case 5:
                print("Trigonometric substitition is one method of dealing with integrals.");
                break;
            case 4:
                print("I have a lot of math to do.  Oh, bother.");
                break;
            case 3:
                print("I wish I could eat pizza all day.  Whadda ya say?");
                break;
            case 2:
                print("Me like ice cream.  Me like cookie.");
                break;
            case 1:
                print("You give tasty!  Rrraarrrgh!");
                break;
            default:
                print("Incorrect IQ level.  Try again.");
                break;

        } // end of switch
    } // end of Greet
}
