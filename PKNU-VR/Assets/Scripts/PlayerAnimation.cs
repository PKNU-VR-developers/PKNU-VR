using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private GameObject parentObject;
    private Animator _animator;                         // Add Animator Component 
    private Vector2 _Vector2;
    private Vector2 _DefaultAngularVector2;
    private float controller;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _Vector2 = new Vector2(0, 0);
        _DefaultAngularVector2 = new Vector2(1, 0);
        characterController = gameObject.transform.root.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()


    {
        if (characterController.isGrounded && Input.GetKeyDown(KeyCode.Space)) //|| OVRInput.GetDown(OVRInput.Button.One))
        {
            gameObject.transform.root.gameObject.GetComponent<PlayerMovement>().Jumping();
            _animator.SetBool("Jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space) || OVRInput.GetUp(OVRInput.Button.One))
        {
          _animator.SetBool("Jump", false);
        }
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
            controller = 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
            controller = 2;
        }
        if ((Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1))
            {
            controller = 3;
        }

        //walking forward
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || ((Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -67.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -112.5))
        {
            _animator.SetBool("Forwards", true);
           
        }
        if (controller == 1 && (_animator.GetBool("Forwards") == true) && Input.GetKeyUp(KeyCode.W)) 
        { 
            _animator.SetBool("Forwards", false);
        }
        if (controller == 2 && (_animator.GetBool("Forwards") == true) && Input.GetKeyUp(KeyCode.UpArrow))
        {
            _animator.SetBool("Forwards", false);
        }
        if (controller == 3 && (_animator.GetBool("Forwards") == true) && Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Forwards", false);
        }

        //walking backward
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 112.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 67.5)
        {
            _animator.SetBool("Backwards", true);
        }
        if (controller == 1 && (_animator.GetBool("Backwards") == true) && Input.GetKeyUp(KeyCode.S))
        {
            _animator.SetBool("Backwards", false);
        }
        if (controller == 2 && (_animator.GetBool("Backwards") == true) && Input.GetKeyUp(KeyCode.DownArrow))
        {
            _animator.SetBool("Backwards", false);
        }
        if (controller == 3 && (_animator.GetBool("Backwards") == true) && Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Backwards", false);
        }

        // walking left
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -157.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -180) || (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 157.5 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < 180))
        {
            _animator.SetBool("Left", true);
        }
        if (controller == 1 && (_animator.GetBool("Left") == true) && Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("Left", false);
        }
        if (controller == 2 && (_animator.GetBool("Left") == true) && Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _animator.SetBool("Left", false);
        }
        if (controller == 3 && (_animator.GetBool("Left") == true) && Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Left", false);
        }

        // walking right
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 22.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -22.5)
        {
            _animator.SetBool("Right", true);
        
        }
        if (controller == 1 && (_animator.GetBool("Right") == true) && Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("Right", false);
        }
        if (controller == 2 && (_animator.GetBool("Right") == true) && Input.GetKeyUp(KeyCode.RightArrow))
        {
            _animator.SetBool("Right", false);
        }
        if (controller == 3 && (_animator.GetBool("Right") == true) && Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Right", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.9)
            _animator.SetBool("Run", true);
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.9)
            _animator.SetBool("Run", false);

    }
 
}
