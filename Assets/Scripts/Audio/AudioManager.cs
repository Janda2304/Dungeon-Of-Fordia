using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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
