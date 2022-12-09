using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class VolumeManager : MonoBehaviour
{
     public Slider masterVolumeSlider;
    

    public void ChangeMasterVolume()
    {
        AudioListener.volume = masterVolumeSlider.value;
        Save();
    }


    public void Load()
    {
        
        masterVolumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    private  void Save()
    {
        PlayerPrefs.SetFloat("masterVolume", masterVolumeSlider.value);
        
    }
}
