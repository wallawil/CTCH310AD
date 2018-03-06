/*  Code by:    Will Wallace
 *  Student ID: 200265595
 *  Date: February 13, 2018
 *  CTCH 310 - Winter 2018
 *  This script is intended to make the bunny chase the player if the player approaches too closely.
 *  The bunny will change from following to fleeing if the player continues to get closer.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnyfollow : MonoBehaviour
{

    public float speed;
    
    //player variable is the monster's target and is assigned in the Inspector console
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized;

        //calculate distance from monster to player
        float distance = Vector3.Distance(player.transform.position, transform.position);

        //if player comes too close, begin moving towards them
        if (distance < 5)
        {
            transform.Translate(localPosition.x * Time.deltaTime * speed,
            localPosition.y * Time.deltaTime * speed,
            localPosition.z * Time.deltaTime * speed);
        }

        //if the distance becomes too short, bunny will change tack and attempt to flee at high speed
        if (distance < 1)
        {
            //change direction with a multiplier applied to the usual speed
            transform.Translate(localPosition.x * Time.deltaTime * speed * (-10),
            localPosition.y * Time.deltaTime * speed * (-10),
            localPosition.z * Time.deltaTime * speed);
        }
    }
}