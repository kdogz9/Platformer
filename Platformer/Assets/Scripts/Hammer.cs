using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public float swingSpeed = 2.0f; // Speed of the hammer swing
    public float swingAngle = 45.0f; // Maximum angle to swing to each side

    private float startAngle;
   

    void Start()
    {
        // Initialize the starting rotation of the hammer
        startAngle = transform.rotation.eulerAngles.z;
    }

    void Update()
    {
        SwingHammer();
    }

    void SwingHammer()
    {
        // Calculate the current rotation angle based on the sine function to create a smooth back and forth motion
        float angle = swingAngle * Mathf.Sin(Time.time * swingSpeed);

        // Apply the rotation to the hammer using the calculated angle
        transform.rotation = Quaternion.Euler(0, 0, startAngle + angle);
    }
}
