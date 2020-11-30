using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemies : MonoBehaviour
{
    public GameObject Object;
    public float maxPos = 2000f;
    public float minPos = 9f;
    
    public int max = 22;
 
    void Start(){
        StartCoroutine(Spawn());
    }
 
    IEnumerator Spawn() 
    {
        for (var i = 0; i < max; i++)
        {
            yield return new WaitForSeconds(2f);
            var NewPos= new Vector3 (Random.Range(minPos,maxPos),0,Random.Range(minPos,maxPos));
            NewPos.y = Object.transform.position.y;
            GameObject go = Instantiate(Object);
            go.transform.position = NewPos;
        }
    }
}
