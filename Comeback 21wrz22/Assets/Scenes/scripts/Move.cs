using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    Rigidbody rb;
    [SerializeField] private float rotationSpeed;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("SIEMA");
    }
    void Update()
    {
        movement();
    }

    public void movement()
    {
        float xvalue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        //transform.Translate(xvalue,0,zvalue);
        Vector3 movementDirection = new Vector3(xvalue, 0, zvalue);
        movementDirection.Normalize();
        transform.Translate(movementDirection * (moveSpeed * Time.deltaTime),Space.World);
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
