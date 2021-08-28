using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour {

    public float speed = 3f;
    public float yVelocity = 0;
    public float gravity = -15f;
    public float jumpPower = 5f;
    private float h;
    private float v;

    Vector3 dir;

    CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (!controller.isGrounded)
        { 
            yVelocity -= gravity * Time.deltaTime;
        }
          
           
        
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, yVelocity, v);


        controller.Move(dir * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            speed = speed * 1.5f;

        if (Input.GetKeyUp(KeyCode.LeftShift)||Input.GetKeyUp(KeyCode.RightShift))
            speed = 5f;


    }
    public void Jumping() // This function will be called from PlayerAnimation Script
    {
        yVelocity = -gravity * Time.deltaTime;
        yVelocity = jumpPower;
    }

}
 
