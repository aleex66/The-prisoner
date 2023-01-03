using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PoopFlush : MonoBehaviour
{
    public AudioClip flush;
    private AudioSource _source;

    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!_source.isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
