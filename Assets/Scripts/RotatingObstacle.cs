using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
        //creating the foundational variables for how much and how fast the Cylinders will rotate
        public float speed = 10.0f;
        public float rotationSpeed;

    void Rotate()
    {
        //Rotating at a constant rate
        transform.Rotate(Vector3.right * speed);

        //Have the cylinders move at the same pace as time passed
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}