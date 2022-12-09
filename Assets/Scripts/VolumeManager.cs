using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
     public Slider masterVolumeSlider;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("masterVolume"))
        {
            PlayerPrefs.SetFloat("masterVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
        
    }

    public void ChangeMasterVolume()
    {
        AudioListener.volume = masterVolumeSlider.value;
        Save();
    }


    private void Load()
    {
        masterVolumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("masterVolume", masterVolumeSlider.value);
        
    }
}
