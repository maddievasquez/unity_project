using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMove : MonoBehaviour
{
    public float speed = 6f;
    public float turnSpeed = 12f;
    float gravity = 9.87f;
    public float jumpSpeed = 6f;
    public Vector3 jumpDirection = Vector3.zero;
    public CharacterController control;

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");/*assign controls to axes*/
        float v = Input.GetAxis("Vertical");
        Vector3 move = (transform.forward * v); /*forward player movement*/
        transform.Rotate(0, h * (turnSpeed * Time.deltaTime), 0); /*rotate player on Y-axis*/

        /*APPLY THE ABOVE TO CHARACTER CONTROLLER COMPONENT*/
        control.Move(move * speed * Time.deltaTime + jumpDirection * Time.deltaTime);
        /*JUMP*/
        if (control.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            jumpDirection.y = jumpSpeed;
        }
        else if (!control.isGrounded)
        {
            jumpDirection.y -= gravity * Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    // Start is called before the first frame update
    void Start()
    {

    }


}
