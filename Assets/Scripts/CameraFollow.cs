using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //Creaying a variable for the camera so it follows the ball as it progresses
    public GameObject player;
    private Vector3 offset = new Vector3(30,0,10);
    

    void LateUpdate()
    {
        //Binding it into a LateUpdate for progression
        transform.position = player.transform.position + offset;
    }
}
