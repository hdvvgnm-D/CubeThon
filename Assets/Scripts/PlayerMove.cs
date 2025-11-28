using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //bool isAlive = true;
    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<=-1f)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
