using UnityEngine;
using System.Collections;
 
public class RandomAudio : MonoBehaviour
{
    [SerializeField] private AudioClip[] gameAudioClips;
    [SerializeField] private AudioSource audioSource;
    
 
    // Use this for initialization
    void Start ()
    {
        if (!audioSource.playOnAwake)
        {
            audioSource.clip = gameAudioClips[Random.Range(0, gameAudioClips.Length)];
            audioSource.Play();
        }
    }
     
    // Update is called once per frame
    void Update ()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = gameAudioClips[Random.Range(0, gameAudioClips.Length)];
            audioSource.Play();
        }
    }
}
