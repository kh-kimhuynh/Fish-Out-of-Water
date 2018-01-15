using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public KeyCode LeftTurnKey;
    public KeyCode RightTurnKey;
    public KeyCode LaunchKey;
    public Rigidbody2D rigidBody;
    public float forceRight;
    public float forceUp;
    public float torque;
    
    void Update()
    {
        if (Input.GetKeyDown(LaunchKey))
        {
            rigidBody.AddForce(transform.right * forceRight);
            rigidBody.AddForce(transform.up * forceUp);
        }
    }

    void Start()
    {
        
    }
}
