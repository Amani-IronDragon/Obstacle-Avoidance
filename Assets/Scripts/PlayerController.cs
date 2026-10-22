using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //The speed of the player while trying to avoid the obstacles
    public float speed = 10.0f;
    //The speed of the player when moving left/right
    public float turnSpeed = 20.0f;
    //Taking the horizontal and vertical input of the player
    public float horizontalInput;
    public float forwardInput;

    void Update()
    {
        //Command that the player move at the pace of second, so that time dictates speed

        //Taking player input (a,s,w,d/arrows) for horizontal and vertical inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the player forward, while also allowing for turns
        transform.Translate(Vector3.back  * speed * forwardInput * Time.deltaTime);
        transform.Translate(Vector3.left  * turnSpeed * horizontalInput * Time.deltaTime) ;
    }
}
