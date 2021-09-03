using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour {

    public float speed = 1f;
    public float yVelocity = 0;
    public float gravity = 15f;
    public float jumpPower = 4f;
    private Vector3 h;
    private Vector3 v;

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
          
           
        
        h = transform.right * Input.GetAxis("Horizontal");
        v = transform.forward * Input.GetAxis("Vertical");
        dir = new Vector3(0, yVelocity, 0)+ h + v;


        controller.Move(dir * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            speed = speed * 4f;

        if (Input.GetKeyUp(KeyCode.LeftShift)||Input.GetKeyUp(KeyCode.RightShift))
            speed = 1f;


    }
    public void Jumping() // This function will be called from PlayerAnimation Script
    {
        yVelocity = -gravity * Time.deltaTime;
        yVelocity = jumpPower;
    }

}
 
