using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchTrigger : MonoBehaviour
{
   [SerializeField] private GameObject torchLight;
   private bool isActive = true;

   void OnMouseDown()
   {
      if (isActive)
      {
         torchLight.SetActive(false);
         isActive = false;
      }
      else if(!isActive)
      {
         torchLight.SetActive(true);
         isActive = true;
      }
   }


   

}
