using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;


public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;
    
    public AudioSource audioSource;
    
    

    public  IEnumerator playAudio()
    {
        yield return null;

        for (int i = 0; i < clips.Length; i++)
        {
            audioSource.clip = clips[i];
            audioSource.Play();

            while (audioSource.isPlaying)
            {
                yield return null;
            }

        }
    }
    
  
    
    
    void Start()
    {
      
       
       
        
            StartCoroutine(playAudio());
        
       


    }



}
