using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    Rigidbody rb;
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
        
        transform.Translate(xvalue,0,zvalue);
    }
}
