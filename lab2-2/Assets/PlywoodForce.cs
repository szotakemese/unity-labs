using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlywoodForce : MonoBehaviour
{
    public float thrust = 3000f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);
    }

}
