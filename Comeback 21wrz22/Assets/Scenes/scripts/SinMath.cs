using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SinMath : MonoBehaviour
{
    [SerializeField] private Vector3 movementVector;
    Vector3 startPosition;
    float movementFactor;
    [SerializeField] float period = 10f;

    private void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    private void Update()
    {
        
        sinMathObj();
    }

    void sinMathObj()
    {
        if (period <= Mathf.Epsilon)
        {
            return;
        }

        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);
        movementFactor = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startPosition + offset;
    }
}
    
