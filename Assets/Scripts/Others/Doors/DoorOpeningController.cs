using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningController : MonoBehaviour
{
    public GameObject door;
    public Animation doorAnimation;
   
    public AudioSource _audioSource;
    public AudioClip doorAudio;
    public bool isClosed = true;
    

    void OnMouseDown()
    {
        if (isClosed && !doorAnimation.isPlaying)
        {
            
            doorAnimation.Play("doorOpen");
            _audioSource.PlayOneShot(doorAudio);
            isClosed = false;
            
        }
        else if(!isClosed && !doorAnimation.isPlaying)
        {
            doorAnimation.Play("doorClose");
            _audioSource.PlayOneShot(doorAudio);
            isClosed = true;
        }
    }
    
    
    
    
}
