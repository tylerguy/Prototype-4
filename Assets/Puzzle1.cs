using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    [SerializeField] private GameObject puzzle1;
    [SerializeField] private Vector3 puzzle1Target;
    [SerializeField] float puzzle1speed;

    private void Update()
    {
       float puzzle1step = puzzle1speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        puzzle1.transform.position = Vector3.MoveTowards(puzzle1.transform.position, puzzle1Target, puzzle1speed);
    }






}
