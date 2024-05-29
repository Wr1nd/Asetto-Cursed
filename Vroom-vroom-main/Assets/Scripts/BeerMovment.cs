using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerMovment : MonoBehaviour
{
    //rotate beer bottle
    public float speed = 5.0f;
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
    
    
    
    
    
    
    
}
