using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftorRight : MonoBehaviour
{

    public float moveDistance = 5f; // the distance the object moves at 
    public float moveSpeed = 2; // how fast it moves

    // moving back and forth between positions 
    private Vector3 startPosition;
    private bool movingForward = true;

    private void Start() //get the initial position of the object 
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        //target position
        Vector3 targetPosition = movingForward ? startPosition + Vector3.forward * moveDistance : startPosition - Vector3.forward * moveDistance;
        //move object towards target position 
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        //check if the object has reached the target and then reverse the direction 
        if (transform.position == targetPosition)
        {
            movingForward = !movingForward;
        }
    }
}
