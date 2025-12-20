using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody2D rb;
    public float speed;
    public WheelJoint2D leftWheel;
    public WheelJoint2D rightWheel;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       leftWheel.useMotor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //rb.AddForce(transform.right * speed * Time.deltaTime
            var MyNewMotor = new JointMotor2D();
            MyNewMotor.motorSpeed = rightWheel.motor.motorSpeed + speed * Time.deltaTime;
            MyNewMotor.maxMotorTorque = 10000;
            leftWheel.motor = MyNewMotor;
            rightWheel.motor = MyNewMotor;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //rb.AddForce(transform.right * speed * Time.deltaTime
            var MyNewMotor = new JointMotor2D();
            MyNewMotor.motorSpeed = rightWheel.motor.motorSpeed - speed * Time.deltaTime;
            MyNewMotor.maxMotorTorque = 10000;
            leftWheel.motor = MyNewMotor;
            rightWheel.motor = MyNewMotor;
        }



    }
    }
