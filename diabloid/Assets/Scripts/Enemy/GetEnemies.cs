using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnemies : MonoBehaviour
{
    public GameObject toClone;
    
    private GameObject clone;
    
    public float xmaxPos = 14.5f;
    public float xminPos = -14.5f;
    public float zmaxPos = 9.5f;
    public float zminPos = -9.5f;
    public float interval = 2f;
    public int max = 15;
 
    void Start(){
        StartCoroutine(CloneMaker());
    }
 
    IEnumerator CloneMaker() 
    {
        for (var i = 0; i < max; i++)
        {
            yield return new WaitForSeconds(interval);
            var NewPos= new Vector3 (Random.Range(xminPos,xmaxPos),0,Random.Range(zminPos,zmaxPos));
            NewPos.y = 1;

            GameObject clone = Instantiate(toClone, transform) as GameObject;
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            clone.transform.position = NewPos;
        }
    }
}
