using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowClick : MonoBehaviour
{
    private Vector3 PositionToMove;
    private bool PositionSelected;
    public float Speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            PositionSelected = Physics.Raycast(ray, out hit);
            if(PositionSelected)
                PositionToMove = hit.point;
        }

        if(PositionSelected){
            Vector3 newPosition = Vector3.MoveTowards(transform.position, PositionToMove, Speed * Time.deltaTime);
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
    }
}
