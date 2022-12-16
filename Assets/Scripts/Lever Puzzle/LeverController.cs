using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{
    [SerializeField] private Animation leverAnimation;
    [HideInInspector] public bool isLeverPressed;
    [SerializeField] private AudioSource leverSound;
    
    
    void OnMouseDown()
    {
        if (!isLeverPressed && !leverAnimation.isPlaying)
        {
            leverSound.Play();
            leverAnimation.Play("leverActivate");
            isLeverPressed = true;

        }
        else if (isLeverPressed && !leverAnimation.isPlaying)
        {
            leverSound.Play();
            leverAnimation.Play("leverDeactivate");
            isLeverPressed = false;
        }

         

    }
}
