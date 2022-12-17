using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Burning _Burning;
    public PlayerMovement movement;
    public WallPressControl _wallPress1;
    public WallPressControl _wallPress2;
    public int level;
    public float walkSpeed;
    public float runSpeed;
    public int jumpHeight;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;

        if (_Burning.isDeath)
        {
            _Burning.deathScreen.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        if (_wallPress1.isDeath || _wallPress2.isDeath)
        {
            _wallPress1.deathScreen.SetActive(false);
            _wallPress2.deathScreen.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }


        walkSpeed = movement.walkSpeed;
        runSpeed = movement.sprintSpeed;
        jumpHeight = movement.jumpHeight;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    }
}

