using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WallDestroy : MonoBehaviour
{
  
    public bool isTouching = false;
    public float maxDistance = 5;
    [SerializeField] private GameObject wall;

    void OnTriggerStay(Collider other)
    {
        // other object is close
        if (Vector3.Distance(other.transform.position, this.transform.position) < maxDistance)
        {
            isTouching = true;
            wall.SetActive(false);
            // they are touching AND close
        }
        else 
        {
            isTouching = false;
        }
    }
}
