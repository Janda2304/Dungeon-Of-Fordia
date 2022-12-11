using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorOpening : DoorOpeningController
{
    public bool haveKey = false;


    void OnMouseDown()
    {
        if (isClosed && !doorAnimation.isPlaying && haveKey)
        {
            
            doorAnimation.Play("doorOpen");
            _audioSource.PlayOneShot(doorAudio);
            isClosed = false;
            
        }
        else if(!isClosed && !doorAnimation.isPlaying && haveKey)
        {
            doorAnimation.Play("doorClose");
            _audioSource.PlayOneShot(doorAudio);
            isClosed = true;
        }
    }
}
