using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;                         // Add Animator Component 
    private Vector2 _Vector2;
    private Vector2 _DefaultAngularVector2;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _Vector2 = new Vector2(0, 0);
        _DefaultAngularVector2 = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()


    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)|| (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < -45) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -135)
        {
            _animator.SetBool("Forwards", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Forwards", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < 135) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 45)
            _animator.SetBool("Backwards", true);
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Backwards", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < -135) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -180) || (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 135 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < 180))
            _animator.SetBool("Left", true);
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Left", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < 45) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -45)
            _animator.SetBool("Right", true);
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Right", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.W))
            _animator.SetBool("ForwardsLeft", true);
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W))
            _animator.SetBool("ForwardsLeft", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.W))
            _animator.SetBool("ForwardsRight", true);
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
            _animator.SetBool("ForwardsRight", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.S))
            _animator.SetBool("BackwardsRight", true);
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S))
            _animator.SetBool("BackwardsRight", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S))
            _animator.SetBool("BackwardsLeft", true);
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S))
            _animator.SetBool("BackwardsLeft", false);
        if (Input.GetKeyDown(KeyCode.L))
            Debug.Log(Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2));
    }
 
}
