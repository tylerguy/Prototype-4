using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    public GameObject Puzzle2Obj;
    public Transform newloc;
    public float speed;
    

    void OnTriggerEnter(Collider other)
    {
       float step = speed * Time.deltaTime;
        Puzzle2Obj.transform.position = Vector3.MoveTowards(Puzzle2Obj.transform.position, newloc.position, step);
        Debug.Log("collision");
    }
}
