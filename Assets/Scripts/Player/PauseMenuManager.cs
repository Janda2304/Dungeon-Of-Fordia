using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject crosshair;
    private KeyCode pauseKey = KeyCode.Escape;

    void Start()
    {
        pauseMenu.SetActive(false);
    }
    void Update()
    {
       

        if (Input.GetKeyDown(pauseKey) && !pauseMenu.activeInHierarchy)
        {
            crosshair.SetActive(false);
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            
            
        }
        else if (Input.GetKeyDown(pauseKey) && pauseMenu.activeInHierarchy)
        {
            crosshair.SetActive(true);
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        
        
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
       
    }

    
}
