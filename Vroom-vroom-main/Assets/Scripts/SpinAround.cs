using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAround : MonoBehaviour
{
    //spin camera around object
    public GameObject target;
    public float speed = 5.0f;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - target.transform.position;
    }
    
    void Update()
    {
        offset = Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up) * offset;
        transform.position = target.transform.position + offset;
        transform.LookAt(target.transform.position);
    }
    
}
