using UnityEngine;
using UnityEngine.SceneManagement;

public class WallPressControl : MonoBehaviour
{
    [SerializeField] private Animator _animator1;
    [SerializeField] private Animator _animator2;
    public AudioSource source;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private PlayerMovement _playerMovement;
    
    // Update is called once per frame
    void FixedUpdate()
    {
            _animator1.Play("Base Layer.wallLeftPress");
            _animator2.Play("Base Layer.wallRightPress"); 
        
            
    }


    
    


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
    
    
   

    public void BonkSound()
    {
        source.Play();
    }
}
