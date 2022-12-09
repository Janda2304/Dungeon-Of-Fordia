using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private KeyCode pauseKey = KeyCode.Escape;

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    void FixedUpdate()
    {
       

        if (Input.GetKeyDown(pauseKey) && !pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            
            
        }
        else if (Input.GetKeyDown(pauseKey) && pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false); 
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        
        
    }
}
