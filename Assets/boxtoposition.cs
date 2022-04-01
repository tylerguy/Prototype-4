using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxtoposition : MonoBehaviour
{
    [SerializeField] private GameObject puzzle1;
    [SerializeField] private Vector3 puzzle1Target;
    [SerializeField] private float puzzle1speed;

    private void OnCollisionrEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            puzzle1.transform.position = Vector3.MoveTowards(puzzle1.transform.position, puzzle1Target, Time.deltaTime * puzzle1speed);
            Debug.Log("Collision With Box");
        }
        else
        {
            Debug.Log("Collision");
        }
    }
}
