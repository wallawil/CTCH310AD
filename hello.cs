using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //an introduction to be printed only once at runtime
       // print("Hi, everybody!");
       // print("Hi, Dr. Nick!");
    }

    // Update is called once per frame
    void Update()
    {
        // this is an example of a comment
        /* this is also a comment, but it must be closed with another star and slash */

        //hide the cursor and lock its state
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // call the Move function every frame to check for input from user
        Move();
    }

    Vector3 playerPosition()
    {
        return this.transform.position;
    }



    // We put all the movement-related commands into their own function for the sake of uncluttering
    void Move()
    {
        // allow user to look around with the mouse
        float h = 5 * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);

        float v = 5 * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, 0, 0);

        // W and S for moving forward and backward; A and D for strafing left and right
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, 0.2f, 0f);
        }


        //look left or right along y axis with left/right arrows (the mouse can also be used for this)
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 2.0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -2.0f, 0f);
        }
        

        //look up or down by rotating along x axis with up/down arrows (again, the mouse can also be used for this)
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-2.0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(2.0f, 0f, 0f);
        }

    }  // end of move function

} 