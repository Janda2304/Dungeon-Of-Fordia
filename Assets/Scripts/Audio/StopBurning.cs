using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBurning : MonoBehaviour
{
    [SerializeField] private FireSound _fireSound;
    
    void OnTriggerEnter(Collider other)
    {
       
        _fireSound.fireSource.SetActive(false);
        





    }
}
