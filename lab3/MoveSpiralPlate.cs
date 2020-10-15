using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpiralPlate : MonoBehaviour
{
    public float Speed_movement = 0.1f;
    public Vector3 Direction1;
    public Vector3 Direction2;
    public float Speed_rotation = 50f;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Direction1 = transform.up;
        Direction2 = transform.forward;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction1 * Speed_movement * Time.deltaTime);
        transform.Translate(Direction2 * Speed_movement * Time.deltaTime);
        transform.RotateAround(Target.transform.position, Vector3.up, Speed_rotation * Time.deltaTime);
    }
}
