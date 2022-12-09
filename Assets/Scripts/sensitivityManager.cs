using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensitivityManager : MonoBehaviour
{
    public Slider sensitivitySlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("mouseSensitivity"))
        {
            PlayerPrefs.SetFloat("mouseSensitivity", 500);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeMouseSensitivity()
    {
        MouseLook.mouseSensitivity = sensitivitySlider.value;
        Save();
    }
    
    private void Load()
    {
        sensitivitySlider.value = PlayerPrefs.GetFloat("mouseSensitivity");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("mouseSensitivity", sensitivitySlider.value);
        
    }
    
}
