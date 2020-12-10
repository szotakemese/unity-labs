using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    void Start(){
        StartCoroutine(WaitAndDestroy());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    
    IEnumerator WaitAndDestroy() 
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
