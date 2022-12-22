using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    //[SerializeField] private float jumpSpeed = 1000f;
    [SerializeField] private float jumpForce = 5f;
    private bool isGrounded;
    public float jumpTime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground" )
        {
            jumpForce = 5f;
            isGrounded = true;
        }
        else if (other.gameObject.tag == "Jumper")
        {
            jumpForce = 11f;
            isGrounded = true;
        }
    }

    void ProcessThrust()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            //rb.AddRelativeForce(Vector3.up * jumpSpeed * Time.deltaTime);
            Debug.Log("DUPA");
            isGrounded = false;
        }
        
    }
    //rb.velocity = Vector2.up * jumpForce;

    void Update()
    {
        ProcessThrust();
    }
}
    

