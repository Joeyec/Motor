using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorControll : MonoBehaviour {
    public WheelJoint2D right;
    public WheelJoint2D left;
    // Use this for initialization
    [SerializeField] float speed = 1500f;
    [SerializeField] float rotate = 1500f;
    Rigidbody2D rg;
    JointMotor2D motor;
    void Start () {
        motor.maxMotorTorque = 10000;
        rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        motor.motorSpeed = -speed * Input.GetAxis("Horizontal");
        right.motor = motor;
        left.motor = motor;
        rg.AddTorque(rotate * Input.GetAxis("Vertical")*Time.deltaTime);
	}
}
