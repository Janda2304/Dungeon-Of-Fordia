using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Burning : MonoBehaviour
{
    public GameObject deathScreen;
    [HideInInspector] public bool isDeath;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isDeath)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            isDeath = true;
        }
        
        

    }

   

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
