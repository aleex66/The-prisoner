using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float xValue = 0f;
    [SerializeField] private float yValue = 1f;
    [SerializeField] private float zValue = 0f;
     //MeshRenderer _renderer;
    void Spinning()
    {
        transform.Rotate(xValue,yValue,zValue);
    }
    
    private void Start()
    {
       // _renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
       Invoke("Spinning", 3f);
    }
}
