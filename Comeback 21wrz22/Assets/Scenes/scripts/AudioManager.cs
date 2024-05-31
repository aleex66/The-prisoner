using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public SoundMaker[] sounds;
    static AudioManager instance;
    //bool isPlayin;
    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (SoundMaker s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
            s.source.playOnAwake = s.playOnAwake;
        }
        
    }

    public void Start()
    {
       AudioManager.instance.Play("melodyjka");
      // isPlayin = true;
       
    }

    public void Play(string songName)
    {
        SoundMaker s = Array.Find(sounds, sound => sound.songName == songName);
        if (s == null)
        {
            return;
        }
        s.source.Play();
    }
}
