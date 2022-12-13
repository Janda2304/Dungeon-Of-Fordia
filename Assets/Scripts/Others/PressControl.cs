
using UnityEngine;

public class PressControl : MonoBehaviour
{
    [SerializeField] private Animation pressAnimation;
    [SerializeField] private Collider fakeFloorCollider;
    [SerializeField] private GameObject fakeFloor;
    [SerializeField] private GameObject press;
    [SerializeField] private GameObject movingFloor;
    [SerializeField] private Collider movingFloorCollider;
    [SerializeField] private AudioSource BonkSource;
    [SerializeField] private AudioClip BonkClip;
    [SerializeField] private Vector3 movingFloorPos = new Vector3(10.5975f, -10.75f, -15.77f);
    private bool pressed = false;

    void Update()
    {
        #region Animation Control
        if (!pressAnimation.isPlaying && !pressed)
        {
            pressAnimation.Play("pressDown");
            pressed = true;
        }
        else if (!pressAnimation.isPlaying && pressed)
        {
            BonkSource.PlayOneShot(BonkClip);
            pressAnimation.Play("pressUp");
            pressed = false;
        }
        

        #endregion Animation Control

        #region Moving Floor On/Off
        if (press.transform.position.y >= -0.2f)
        {
            
            movingFloor.SetActive(true);
            fakeFloorCollider.enabled = false;
        }
        else
        {
            
            movingFloor.SetActive(true);
            fakeFloor.SetActive(true);
        }
        #endregion Moving Floor On/Off

        
       
       

    }

    void OnTriggerEnter(Collider other)
    {
        #region Fake Floor Collider On/Off
       
            fakeFloorCollider.isTrigger = true;
         
           
        
                
          
        
        

        #endregion Fake Floor Collider On/Off
    }

    void OnTriggerExit(Collider other)
    {
        fakeFloor.SetActive(true);
        fakeFloorCollider.isTrigger = false;
        movingFloorCollider.isTrigger = false;
    }

   
       
    
}
