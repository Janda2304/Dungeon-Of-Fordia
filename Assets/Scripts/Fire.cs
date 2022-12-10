using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    
    [SerializeField] private GameObject fireSource;


    void Start()
    {
        fireSource.SetActive(false); 
    }
    
    void OnTriggerEnter(Collider other)
    {
       
            fireSource.SetActive(true);
            
        
       


    }
}
