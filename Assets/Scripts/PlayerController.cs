using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Member variables
    Rigidbody2D rb2d;
    [SerializeField] float fltTorqueAmount = 1f;
    SurfaceEffector2D surfaceEffecor2D;
    [SerializeField] float fltBoostSpeed = 30f;
    [SerializeField] float fltBaseSpeed = 20f;
    bool canMove = true;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffecor2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControl()
    {
        canMove = false;
    }
     void RotatePlayer()
    {
        //if you press the left key, turn left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(fltTorqueAmount);
            Debug.Log("Left Torque");
        }
        //Else so that you cant do both at the same time, but if you hit the right key, turn right
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-fltTorqueAmount);
            Debug.Log("Right Torque");
        }

     

        }

    void RespondToBoost()
    {
        // if we push up, speed up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffecor2D.speed = fltBoostSpeed;

        }
        else
        {
            surfaceEffecor2D.speed = fltBaseSpeed;
        }
    }




}
