using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System;


public class PhonePlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float maxspeed = 50f;
    private float sidewaysForce = GameData.SideForce;
    public float jumpForce = 100f;

    //public Transform playerSize;
    public float changeFormSpeed = 0.1f;
    public float changeLimitLow = 0.5f;
    public float changeLimitTop = 1.5f;
    

    private Vector3 scaleChange;

    // Update is called once per frame
    void FixedUpdate()
    {   
        if(rb.velocity.z < maxspeed) // Forward force
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }
        for(int i = 0; i< Input.touchCount; i++)
        {
            if(Input.touches[i].position.x < 1/3f* (float)Screen.width) // flattening to ground 
            {
                if(transform.localScale.y > changeLimitLow)
                {
                    scaleChange = new Vector3(changeFormSpeed, -changeFormSpeed, 0);
                    transform.localScale += scaleChange;
                }
            }
            else
            {
                if(Input.touches[i].position.x > 2/3f* (float)Screen.width) // flattening from sides
                {
                    if(transform.localScale.y < changeLimitTop )
                    {
                        scaleChange = new Vector3(-changeFormSpeed, changeFormSpeed, 0);
                        transform.localScale += scaleChange;
                    }
                }
                else
                {
                    if(transform.position.y <= 1.1f - (1- transform.localScale.y)/2)
                    {
                        if(transform.position.x >= -8f & transform.position.x <= 8f)
                        {
                            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                        }
                    }       
                }
            }
        }

        if(Math.Abs(rb.velocity.x) < 5)
        {
            if( Math.Abs(Input.acceleration.x)> 0.05 )
            {
                rb.AddForce(sidewaysForce * Input.acceleration.x * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
