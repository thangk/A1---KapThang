using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour
{
    public Vector3 pointA = new Vector3(3, 1, 0);
    public Vector3 pointB = new Vector3(-3, 1, 0);
    public bool movingToB = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == pointA)
        {
            movingToB = true;
        }
        if (transform.position == pointB)
        {
            movingToB = false;
        }

        Vector3 directionToA = Vector3.MoveTowards(transform.position, pointA, Time.deltaTime);
        Vector3 directionToB = Vector3.MoveTowards(transform.position, pointB, Time.deltaTime);

        transform.position = movingToB ? directionToB : directionToA;
    }
}
