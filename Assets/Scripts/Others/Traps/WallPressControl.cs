using UnityEngine;
using UnityEngine.SceneManagement;

public class WallPressControl : MonoBehaviour
{
    [SerializeField] private Animator _animator1;
    [SerializeField] private Animator _animator2;
    public AudioSource source;
    public GameObject deathScreen;
    [SerializeField] private PlayerMovement _playerMovement;
    [HideInInspector] public bool isDeath = false;
    
    // Update is called once per frame
    void FixedUpdate()
    {
            _animator1.Play("Base Layer.wallLeftPress");
            _animator2.Play("Base Layer.wallRightPress");
    }


    
    


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
        
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    
    
    
    
   

    public void BonkSound()
    {
        source.Play();
    }
}
