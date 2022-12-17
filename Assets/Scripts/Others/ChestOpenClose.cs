using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpenClose : MonoBehaviour
{
    [SerializeField] private Animation chestAnimation;
    [SerializeField] private AudioSource chestSound;
    [SerializeField] private AudioSource outroSound;
    [SerializeField] private AudioClip openSound;
    private bool isOpen = false;
    private bool outroPlayed = false;
    
    void OnMouseDown()  
    {
        if (!outroPlayed)
        {
            outroSound.Play();
            outroPlayed = true;
        }
        if (!chestAnimation.isPlaying && !chestSound.isPlaying && !isOpen)
        {
            chestAnimation.Play("chestOpen");
            chestSound.PlayOneShot(openSound);
            isOpen = true;
            
        }
        else if (!chestAnimation.isPlaying && !chestSound.isPlaying && isOpen)
        {
            chestAnimation.Play("chestClose");
            chestSound.PlayOneShot(openSound);
            isOpen = false;
        }
        
                
        
            
        
            
        
    }
}
