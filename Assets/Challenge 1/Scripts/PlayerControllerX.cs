﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float actualRotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float barrelrollInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        barrelrollInput = Input.GetAxis("Rolltal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * actualRotationSpeed * verticalInput);
        transform.Rotate(Vector3.up * actualRotationSpeed * horizontalInput);
        transform.Rotate(Vector3. forward * actualRotationSpeed * barrelrollInput);
    }
}
