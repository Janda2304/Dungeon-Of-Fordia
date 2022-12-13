
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> triggers = new List<GameObject>();
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip gateOpenAudioClip;
    [SerializeField] private Animation gateOpenAnimation;
    [SerializeField] private bool animationFinished = false;
    void FixedUpdate()
    {

        if (triggers[0].activeInHierarchy && triggers[1].activeInHierarchy && triggers[2].activeInHierarchy && triggers[3].activeInHierarchy 
            && triggers[4].activeInHierarchy && triggers[5].activeInHierarchy && !triggers[6].activeInHierarchy && !triggers[7].activeInHierarchy 
            && !triggers[8].activeInHierarchy && !triggers[9].activeInHierarchy && !triggers[10].activeInHierarchy && !triggers[11].activeInHierarchy && !animationFinished)
        {
            gateOpenAnimation.Play("gateOpen");
            source.PlayOneShot(gateOpenAudioClip);
            animationFinished = true;

        }
        
        
        
    }

}

