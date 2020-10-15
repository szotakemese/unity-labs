using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRod : MonoBehaviour
{
    public float Speed = 30f;
    public GameObject Target;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.transform.position, Vector3.up, Speed * Time.deltaTime);
    }
}

