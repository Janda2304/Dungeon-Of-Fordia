using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningController : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private Animation doorAnimation;
   
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip doorAudio;
    private bool isClosed = true;
    

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
