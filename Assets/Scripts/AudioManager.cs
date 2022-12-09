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
    public AudioClip creditsMusic;
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
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Credits")
        {
            audioSource.Stop();
            audioSource.PlayOneShot(creditsMusic);
        }
       
        else
        {
            StartCoroutine(playAudio());
        }
       


    }



}
