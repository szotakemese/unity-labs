using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardSFS : MonoBehaviour
{
    public float Speed = 1f;
    public Vector3 Direction;
    // Start is called before the first frame update
    void Start()
    {
        Direction = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Speed * Time.deltaTime);
       
    }
}
