using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    public bool clip2 = false;
    public AudioSource audioSource;


    void FixedUpdate()
    {
        if (!audioSource.isPlaying && !clip2)
        {
            audioSource.PlayOneShot(clips[0]);
            clip2 = true;
        }
        else if (!audioSource.isPlaying && clip2)
        {
            audioSource.PlayOneShot(clips[1]);
            clip2 = false;
        }
       
    }



}
