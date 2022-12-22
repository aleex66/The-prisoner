using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SoundMaker
{
    public string _name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;

    public bool playOnAwake;
    
    public bool loop;
    
    public AudioSource source;
  
}
