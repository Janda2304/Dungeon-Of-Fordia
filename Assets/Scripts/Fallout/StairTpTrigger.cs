using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTpTrigger : MonoBehaviour
{
    [SerializeField] private FalloutController _fallout;
    [SerializeField] private FalloutController _fallout2;
    [SerializeField] private GameObject trigger;
   
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            _fallout.stairPosTp = true;
            _fallout.tunnelPosTp = false;
            _fallout2.stairPosTp = true;
            _fallout2.tunnelPosTp = false;
            
            trigger.SetActive(false);
        }
    }
}
