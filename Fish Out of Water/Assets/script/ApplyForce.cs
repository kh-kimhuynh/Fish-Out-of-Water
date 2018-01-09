using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public KeyCode LeftTurnKey;
    public Rigidbody2D rigidBody;
    public float forceRight;
    public float forceUp;
    public float torque;

    void Update()
    {
        if (Input.GetKey(LeftTurnKey))
        {
            rigidBody.AddTorque(torque);
        }        
    }

    void Start()
    {
        rigidBody.AddForce(transform.right * forceRight);
        rigidBody.AddForce(transform.up * forceUp);
    }
}
