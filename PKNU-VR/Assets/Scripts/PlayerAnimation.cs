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
        Debug.Log("start position:" + gameObject.transform.parent.gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()


    {
       
        if (Input.GetKeyDown(KeyCode.F) || OVRInput.GetDown(OVRInput.Button.One))
        {
            _animator.SetBool("Jump", true);
        }

        if (gameObject.transform.parent.gameObject.transform.position.y < 1.7)
        {
            Debug.Log("grounded");
            _animator.SetBool("Jump", false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -67.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -112.5)
        {
            _animator.SetBool("Forwards", true);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Left", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
          
        if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
        {
            _animator.SetBool("Forwards", false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 112.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 67.5)
        {
            _animator.SetBool("Backwards", true);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Left", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Backwards", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -157.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -180) || (Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 157.5 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) < 180))
        {
            _animator.SetBool("Left", true);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Left", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 22.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -22.5)
        {
            _animator.SetBool("Right", true);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Left", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("Right", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.W) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -112.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -157.5)
        {
            _animator.SetBool("ForwardsLeft", true);
            _animator.SetBool("Left", false);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("ForwardsLeft", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.W) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > -67.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= -22.5)
        {
            _animator.SetBool("ForwardsRight", true);
            _animator.SetBool("Left", false);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W)|| Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("ForwardsRight", false);

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.S) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 22.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 67.5)
        {
            _animator.SetBool("BackwardsRight", true);
            _animator.SetBool("Left", false);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("BackwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("BackwardsRight", false);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) || (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) > 0.1 && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) > 112.5) && Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2) <= 157.5)
        {
            _animator.SetBool("BackwardsLeft", true);
            _animator.SetBool("Left", false);
            _animator.SetBool("Forwards", false);
            _animator.SetBool("Backwards", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("ForwardsLeft", false);
            _animator.SetBool("ForwardsRight", false);
            _animator.SetBool("BackwardsRight", false);
            if (Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) >= 0.9)
                _animator.SetBool("Run", true);
            else
                _animator.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Vector2.Distance(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _Vector2) < 0.1)
            _animator.SetBool("BackwardsLeft", false);
        if (Input.GetKeyDown(KeyCode.L))
            Debug.Log(Vector2.SignedAngle(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick), _DefaultAngularVector2));
    }
 
}
