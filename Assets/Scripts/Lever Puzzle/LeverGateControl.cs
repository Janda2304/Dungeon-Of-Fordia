using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeverGateControl : MonoBehaviour
{

    [Header("levers")]
    [SerializeField] private LeverController _lever1;
    [SerializeField] private LeverController _lever2;
    [SerializeField] private LeverController _lever3;
    [SerializeField] private LeverController _lever4;
    [SerializeField] private LeverController _lever5;
    [Header("other")]
    [SerializeField] private Animation gateAnimation;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    private bool animPlayed = false;

    void FixedUpdate()
    {
        if (_lever1.isLeverPressed && _lever3.isLeverPressed && _lever4.isLeverPressed && !_lever2.isLeverPressed && !_lever5.isLeverPressed && !animPlayed)
        {
            gateAnimation.Play("gateOpen");
            source.PlayOneShot(clip);
            animPlayed = true;
        }
    }
    
    
    
}
