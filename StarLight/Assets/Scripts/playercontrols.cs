using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrols : MonoBehaviour
{
    float thrust = 2f;
    float rotationSpeed = 180f;
    float maxSpeed = 4.5f;

    private void FixedUpdate()
    {
        ControlPlayer();

        if (GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
        {
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
        }
    }

    private void ControlPlayer()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().AddForce(transform.up * thrust * Input.GetAxis("Vertical"));
    }
}
