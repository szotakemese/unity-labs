using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Player
{
  private bool EnemySelected;
  public GameObject ball;
  public float Speed = 1f;

  void Update()
  {
    if(Input.GetMouseButtonDown(0))
    {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;
      EnemySelected = Physics.Raycast(ray, out hit);
      if(EnemySelected)
      {
        var target = hit.transform;
        if(target.CompareTag("Enemy"))
        {
          GameObject fireball = Instantiate(ball, transform) as GameObject;
          Rigidbody rb = fireball.GetComponent<Rigidbody>();
          var pos = target.position - transform.position;
          pos.y = 0f;
          rb.velocity = pos * Speed;
        }
      }
    }
  }
}
