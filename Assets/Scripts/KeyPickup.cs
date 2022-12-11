using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    
    
    [SerializeField] private GameObject key;
    [SerializeField] private LockedDoorOpening _lockedDoor;


    void OnMouseDown()
    {
        if (key.activeInHierarchy)
        {
            key.SetActive(false);
            _lockedDoor.haveKey = true;
            
        }
        
        
        
    }
}
