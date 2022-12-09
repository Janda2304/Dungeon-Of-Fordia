using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private VolumeManager _volumeManager;
    [SerializeField] private SensitivityManager _sensitivityManager;
   
    
    
    
    void Start()
    { 
        #region PlayerPrefs Load
        if (!PlayerPrefs.HasKey("masterVolume"))
        {
            PlayerPrefs.SetFloat("masterVolume", 1);
            _volumeManager.Load();
        }
        else
        {
            _volumeManager.Load();
        }
        
        if (!PlayerPrefs.HasKey("mouseSensitivity"))
        {
            PlayerPrefs.SetFloat("mouseSensitivity", 500);
            _sensitivityManager.Load();
        }
        else
        {
            _sensitivityManager.Load();
        }
        #endregion PlayerPrefs Load
    }

    public void OnExitButton()
    {
        
        Application.Quit();
        
    }

    public void OnSettingsButton()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ExitSettingsButton()
    {
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
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
