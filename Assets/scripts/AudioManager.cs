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

    public AudioSource breathingSource;

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
    }

    public void NextAudioReady()
    {
        clipIndex++;
    }

    public void PlayBreathing()
    {
        if (breathingSource && !breathingSource.isPlaying)
            breathingSource.Play();
    }

    public void StopBreathing()
    {
        if (breathingSource && breathingSource.isPlaying)
            breathingSource.Stop();
    }

    public float AudioLength()
    {
        return clips[clipIndex].clip.length;
    }
}
