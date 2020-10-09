using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    public float Speed = 200f;
    public GameObject Target;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.transform.position, Vector3.right, Speed * Time.deltaTime);
    }
}