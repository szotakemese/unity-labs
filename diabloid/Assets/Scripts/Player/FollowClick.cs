using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowClick : MonoBehaviour
{
    private Vector3 PositionToMove;
    private bool PositionSelected;
    public float Speed = 10f;
    private bool move;

    private NavMeshAgent Agent;

    private void Start()
    {
        Agent = transform.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            move = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            PositionSelected = Physics.Raycast(ray, out hit);
            if(PositionSelected){
                PositionToMove = hit.point;
                var selection = hit.transform;
                if(!selection.CompareTag("Enemy"))
                {
                    move = true;
                }  
            }
            
        }


        if(PositionSelected)
        {
            if(move)
            {
                Agent.SetDestination(PositionToMove);
            }       
        }
    }
}
