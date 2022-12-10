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
        deathScreen.SetActive(true);
        _playerMovement.sprintSpeed = 0f;
        _playerMovement.walkSpeed = 0f;
        _playerMovement.jumpHeight = 0;
        MouseLook.mouseSensitivity = 0;
        Cursor.lockState = CursorLockMode.None;
        

    }

    public void ExitToMenu()
    {
        
        _playerMovement.sprintSpeed = 15f;
        _playerMovement.walkSpeed = 7f;
        _playerMovement.jumpHeight = 2;
        SceneManager.LoadScene("MainMenu");
    }
}
