using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Member variables
    Rigidbody2D rb2d;
    [SerializeField] float fltTorqueAmount = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //if you press the left key, turn left
        if(Input.GetKey(KeyCode.LeftArrow))
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
}
