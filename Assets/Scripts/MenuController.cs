using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MenuController : MonoBehaviour
{
    
    
    
    
    void Start()
    {
        
    }

    public void OnExitButton()
    {
        
        Application.Quit();
        
    }

    public void OnSettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }

    public void OnPlayButton()
    {
        
        SceneManager.LoadScene("GameScene1");
    }

    public void OnCreditsButton()
    { 
       
        SceneManager.LoadScene("Credits");
        

    }
    
    
  
  
}
