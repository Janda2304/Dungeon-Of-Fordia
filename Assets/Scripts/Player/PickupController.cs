using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public Transform pickupPoint;
    
    void OnMouseDown()
    {
        transform.parent = pickupPoint.transform;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().freezeRotation = true;
    }

    void OnMouseUp()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
       
    }
}
