using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 45.0f;
    [Range(-3f,3f)]
    public float verticalInput;

    [Range(-3f,3f)]
    public float horizontalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical") * 3;
        horizontalInput = Input.GetAxis("Horizontal") * 3;

        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.fixedDeltaTime);
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.fixedDeltaTime);
    }
}