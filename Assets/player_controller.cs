using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*access the rigidbody of the object this script is on*/
    }


    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        /*access predefined horizontal and vertical axis in unity, with arrow keys assigned to it*/

        Vector3 movement = new Vector3(moveH, 0, moveV);
        /*apply our input axis to x and z directions as a vector*/

        rb.AddForce(movement * speed);
        /*add our movement direction multiplied by our speed variable to the rigidbody*/
    }
}
                                                                                                                      