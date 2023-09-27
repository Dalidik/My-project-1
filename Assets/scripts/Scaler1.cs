using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler1 : MonoBehaviour
{
    public float x, y, z;
    public Vector3 scaleChange;
 
    void Update()
    {
        scaleChange = new Vector3 (x * 0.001f, y * 0.001f, z * 0.001f);
        transform.localScale += scaleChange;
    }
}
