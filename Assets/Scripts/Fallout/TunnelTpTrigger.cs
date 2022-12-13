using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelTpTrigger : MonoBehaviour
{
   [SerializeField] private FalloutController _fallout;
   [SerializeField] private FalloutController _fallout2;
   [SerializeField] private GameObject trigger;
   
   void OnTriggerEnter(Collider player)
   {
      if (player.gameObject.tag == "Player")
      {
         _fallout.tunnelPosTp = true;
         _fallout.startPosTp = false;
         _fallout2.tunnelPosTp = true;
         _fallout2.startPosTp = false;
      
         trigger.SetActive(false);
      }
   }
}
