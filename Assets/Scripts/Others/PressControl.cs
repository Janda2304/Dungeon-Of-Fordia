using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressControl : MonoBehaviour
{
    [SerializeField] private Animation pressAnimation;
    [SerializeField] private Collider floorCollider;
    [SerializeField] private GameObject press;
    [SerializeField] private GameObject movingFloor;
    [SerializeField] private Collider movingFloorCollider;
    [SerializeField] private AudioSource BonkSource;
    [SerializeField] private AudioClip BonkClip;
    public bool bonkingEnabled = false;

    void Update()
    {
        
        pressAnimation.Play("press"); 
        
        if(movingFloor.transform.position.y >= -1.9 )
        {
            movingFloor.SetActive(false);
        }
        else
        {
            movingFloor.SetActive(true);
        }

        if (press.transform.position.y <= -1.5f && bonkingEnabled)
        {
            BonkSource.PlayOneShot(BonkClip);
        }

        if (movingFloor.transform.position.y <= 3)
        {
            movingFloorCollider.enabled = false;
        }
        
    }

    
    //pri enternuti hrace a zaroven touchovani podlahy vypni collider podlahy jinak do nothing 
    
    void OnTriggerEnter(Collider other)
    {
        
        floorCollider.enabled = false;
            
            
        
        
        
    }

   
       
    
}
