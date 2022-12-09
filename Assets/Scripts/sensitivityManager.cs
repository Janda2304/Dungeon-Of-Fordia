using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityManager : MonoBehaviour
{
    public  Slider sensitivitySlider;

    
    public void ChangeMouseSensitivity()
    {
        MouseLook.mouseSensitivity = sensitivitySlider.value;
        Save();
    }
    
    public void Load()
    {
        sensitivitySlider.value = PlayerPrefs.GetFloat("mouseSensitivity");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("mouseSensitivity", sensitivitySlider.value);
        
    }
    
}
