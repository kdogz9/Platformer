using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenPoints : MonoBehaviour
{
    // References to the two target points
    [SerializeField] private Transform point0;
    [SerializeField] private Transform point1;

    // Speed of movement
    [SerializeField] private float speed = 2.0f;

    // Direction flag
    private bool isForward = true;

    private void Update()
    {
        // Move towards point1 if moving forward, otherwise move towards point0
        if (isForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, point1.position, speed * Time.deltaTime);

            // Check if the object has reached point1
            if (transform.position == point1.position)
            {
                isForward = false; // Change direction
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, point0.position, speed * Time.deltaTime);

            // Check if the object has reached point0
            if (transform.position == point0.position)
            {
                isForward = true; // Change direction
            }
        }
    }
}

 