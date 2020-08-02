using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PcPlayerMovement : MonoBehaviour
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
        if(rb.velocity.z < maxspeed)
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }
        //Debug.Log(rb.position.y);
        if(Input.GetKey("d") | Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a") | Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w") | Input.GetKey(KeyCode.UpArrow))
        {
            if(transform.localScale.y < changeLimitTop )
            {
                scaleChange = new Vector3(-changeFormSpeed, changeFormSpeed, 0);
                transform.localScale += scaleChange;
            }
        }

        if(Input.GetKey("s") | Input.GetKey(KeyCode.DownArrow))
        {
            if(transform.localScale.y > changeLimitLow)
            {
                scaleChange = new Vector3(changeFormSpeed, -changeFormSpeed, 0);
                transform.localScale += scaleChange;
            }
        }

        if(Input.GetKey("space"))
        {
            if(transform.position.y <= 1.1f - (1- transform.localScale.y)/2)
            {
                if(transform.position.x >= -8f & transform.position.x <= 8f)
                {
                    rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                }
            }
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
