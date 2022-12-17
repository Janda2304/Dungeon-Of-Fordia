using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FalloutController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Vector3 startPosition = new Vector3(20.4f, 3f, 7.52f);
    public Vector3 tunnelPosition = new Vector3(-59.83f, -28.36f, 25f);
    public Vector3 stairPosition = new Vector3(-72.6f, -28.36f, 235.63f);
    public Vector3 torchPuzzlePosition = new Vector3();
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
   [HideInInspector] public bool startPosTp = true;
   [HideInInspector] public bool tunnelPosTp = false;
   [HideInInspector] public bool stairPosTp = false;
   [HideInInspector] public bool torchPuzzlePosTp = false;


    void Start()
   {
       if (startPosTp)
       {
           player.transform.position = startPosition;
       }
       else if (tunnelPosTp)
       {
           player.transform.position = tunnelPosition;
       }
       else if (stairPosTp)
       {
           player.transform.position = stairPosition;
       }
       else if(torchPuzzlePosTp)
       {
           player.transform.position = torchPuzzlePosition;
       }
   }
   
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            source.PlayOneShot(clip);
            if (startPosTp)
            {
                player.transform.position = startPosition;
            }
            else if (tunnelPosTp)
            {
                player.transform.position = tunnelPosition;
            }
            else if (stairPosTp)
            {
                player.transform.position = stairPosition;
            }
        }
       

        
    }
}
