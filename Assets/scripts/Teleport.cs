using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   public float teleportTimer = 3f; 
    private float timer = 0.0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= teleportTimer)
        {
            RandomTeleport();
            timer = 0.0f;
        }
    }

    private void RandomTeleport()
    {
        float randomX = Random.Range(0.0f, 4f); 
        float randomY = Random.Range(0.0f, 4f); 
        float randomZ = Random.Range(0.0f, 4f); 

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);


      transform.position = randomPosition;

       
    }

}
