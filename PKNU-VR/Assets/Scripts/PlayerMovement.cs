using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;
    public float yVelocity = 0;
    public float gravity = -9.8f;
    public float jumpPower = 205f;
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
        if (controller.isGrounded)
        {

            yVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.C))
            {
                yVelocity = jumpPower;
            }
        }
        else
        {
            yVelocity -= gravity * Time.deltaTime;
        }
          
           
        
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        dir = new Vector3(h, yVelocity, v);


        controller.Move(dir * speed * Time.deltaTime);


         
    }
}
 
