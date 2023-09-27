using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ping : MonoBehaviour
{
    public float speedV;
    // Start is called before the first frame update
    void Start()
    {
       speedV = 2f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speedV * Time.deltaTime);
        if (transform.position.z > 3){
            speedV = -speedV;
        }
        if(transform.position.z <-8){
            speedV = 2f;
        }
    }
}
