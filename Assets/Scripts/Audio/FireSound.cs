using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour
{
    
    public GameObject fireSource;


    void Start()
    {
        fireSource.SetActive(false); 
    }
    
    void OnTriggerEnter(Collider other)
    {
       
            fireSource.SetActive(true);
          




    }
}
