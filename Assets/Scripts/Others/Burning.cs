using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Burning : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private PlayerMovement _playerMovement;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            deathScreen.SetActive(true);
            _playerMovement.sprintSpeed = 0f;
            _playerMovement.walkSpeed = 0f;
            _playerMovement.jumpHeight = 0;
            MouseLook.mouseSensitivity = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        
        

    }

    public void ExitToMenu()
    {
        
        _playerMovement.sprintSpeed = 13f;
        _playerMovement.walkSpeed = 7f;
        _playerMovement.jumpHeight = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
