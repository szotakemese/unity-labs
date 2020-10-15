using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float rotationSpeed = 60f;
    public float movementSpeed = 3f;

    public bool PlayerIsOnTheGround = true;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        if(Input.GetButtonDown("Jump") && PlayerIsOnTheGround){
            rb.AddForce(new Vector3(0,7,0), ForceMode.Impulse);
            //PlayerIsOnTheGround = false;
        }

        bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if(isShiftKeyDown){
            movementSpeed = 5;
        }
        else movementSpeed = 3;
    }
}
