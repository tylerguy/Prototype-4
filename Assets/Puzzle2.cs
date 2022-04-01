using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Puzzle2 : MonoBehaviour
{
    public GameObject Puzzle2Obj;
    public Transform newloc;
    public float speed;
    public TextMeshPro textmeshPro;




    void OnTriggerEnter(Collider other)
    {
       
        Puzzle2Obj.transform.Translate(Vector3.down * speed * Time.deltaTime);
        Debug.Log("collision");

        
        textmeshPro.SetText("Now you can");






    }
}
