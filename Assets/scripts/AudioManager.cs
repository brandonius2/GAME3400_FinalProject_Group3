using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public AudioSource clip3;
    public AudioSource clip4;
    public AudioSource clip5;

    public AudioSource[] clips;
    public int clipIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAudio()
    {
        clips[clipIndex].Play();
        clipIndex++;
    }
}
