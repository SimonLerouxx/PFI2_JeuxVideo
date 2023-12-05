using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;


//Travail fait par SImon Leroux et Lucas Romanias

public class PlayerMovement : MonoBehaviour
{

    Vector3 deplacement;
    public float speed = 6;
    public float minSpeed = 6;
    public float maxSpeed = 10;
    [SerializeField] GameObject Camera;
    [SerializeField] float jumpForce = 75;
    Rigidbody rb;
    public bool canJump = false;






    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(deplacement == Vector3.zero)
        {
            speed = minSpeed;
        }
        else
        {
            transform.Translate(deplacement * Time.deltaTime * speed, Space.Self);

            if(speed < maxSpeed)
            {
                speed += 0.01f;
            }
        }
        
        
        //RaycastHit hit;
        //float thickness = 0.5f; //<-- Desired thickness here.
        //Vector3 origin = transform.position;
        //Vector3 direction = transform.TransformDirection(Vector3.down);
        ////if (Physics.SphereCast(origin, thickness, Vector3.down, out hit,0.2f))
        ////{
        ////    Debug.DrawLine(transform.position, hit.point, Color.red);
        ////    canJump = true;
        ////}
        //////Does the ray intersect any objects excluding the player layer
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.85f) || Physics.Raycast(transform.position + new Vector3(0.5f, 0, 0), transform.TransformDirection(Vector3.down), out hit, 0.85f) ||
        //     Physics.Raycast(transform.position + new Vector3(-0.5f, 0, 0f), transform.TransformDirection(Vector3.down), out hit, 0.85f) || Physics.Raycast(transform.position + new Vector3(0, 0, 0.5f), transform.TransformDirection(Vector3.down), out hit, 0.85f) || Physics.Raycast(transform.position + new Vector3(0, 0, -0.5f), transform.TransformDirection(Vector3.down), out hit, 0.85f))
        //{
        //    canJump = true;
        //}
        //else
        //{
        //    canJump= false;
        //}

    }





    public void Move(InputAction.CallbackContext ctx)
    {
        
        if(ctx.performed)
        {
            deplacement = ctx.ReadValue<Vector3>();
        }

        
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && canJump)
        {
            rb.AddForce(new Vector3(0, jumpForce*100*(20-speed), 0));

            canJump = false;
        }
    }

    //public void Sprint(InputAction.CallbackContext ctx)
    //{
    //    if (ctx.performed && canJump)
    //    {;
    //        speed = speedSprint;
    //    }
    //    else if (ctx.canceled)
    //    {
    //        speed = speedNormal;
    //    }
    //}


}
