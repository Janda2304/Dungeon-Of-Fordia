using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestOpenClose : MonoBehaviour
{
    [SerializeField] private Animation chestAnimation;
    [SerializeField] private AudioSource chestSound;
    [SerializeField] private AudioSource outroSound;
    [SerializeField] private AudioClip openSound;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject crosshair;
    private bool isOpen = false;
    private bool outroPlayed = false;
    private bool menuLoaded = true;
    private int bypass = 0;
    
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

    void FixedUpdate()
    {
        if (isOpen && outroPlayed && !chestAnimation.isPlaying)
        {
            menuLoaded = false;
        }

        if (!menuLoaded && bypass == 0)
        {
            menuLoaded = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            endScreen.SetActive(true);
            crosshair.SetActive(false);
        }
    }
    
    
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
        Time.timeScale = 1;
    }
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void ContinuePlaying()
    {
        Time.timeScale = 1;
        bypass = 1;
        endScreen.SetActive(false);
        crosshair.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
