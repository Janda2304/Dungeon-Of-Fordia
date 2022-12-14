using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource screamSource;
    [SerializeField] private AudioClip screamClip;
    [SerializeField] private GameObject trigger;
    private bool stoppedPlaying = false;
    

    
    void OnTriggerEnter(Collider other)
    {
        if (!stoppedPlaying)
        {
            screamSource.PlayOneShot(screamClip);
            stoppedPlaying = true;
           trigger.SetActive(false);
        }
       


    }
}
