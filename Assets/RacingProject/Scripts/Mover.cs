using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject wheelObj;
    public float throttle = 10;
    WheelCollider wheel;
    Rigidbody rb;

    private void Start ()
    {
        wheel = wheelObj.GetComponent<WheelCollider> ();
        rb = this.GetComponent<Rigidbody> ();
    }
    private void FixedUpdate ()
    {
        float speed = 0;

        if ( Input.GetKey (KeyCode.S))
        {
            speed = throttle;
        }
        rb.AddForce ( -transform.up * throttle );
        wheel.motorTorque = speed;
    }
}
