using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
     public Vector3 rotationY = Vector3.up; 
    public float rotationSpeed = 60.0f; 

    private void Update()
    {
       float rotationAngle = rotationSpeed * Time.deltaTime;

        transform.Rotate(rotationY, rotationAngle);
    }
}
