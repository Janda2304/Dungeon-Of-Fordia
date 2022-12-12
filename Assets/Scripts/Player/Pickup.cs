using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //pickup and move around objects with your mouse  like in portal   

    public float speed = 10;
    public float maxDistance = 10;

    private bool isHolding = false;
    private GameObject heldObject;
    private Rigidbody rb;
    [SerializeField] private List<Rigidbody> objectRigidbodies = new List<Rigidbody>();
    [SerializeField] [Range(1, 100)] private float maxVelocity;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
               
                if (hit.distance <= maxDistance)
                {
                    isHolding = true;
                    heldObject = hit.collider.gameObject;
                    rb = heldObject.GetComponent<Rigidbody>();

                }
            }
        }

        if (rb = null)
        {
            print("null");
        }
        else 
        {
            if (Input.GetMouseButtonUp(0))
            {
                isHolding = false;
                heldObject = null;
         
            }

            if (isHolding && heldObject.tag == "Pickup")
            {
                foreach (var _rigidbody in objectRigidbodies)
                {
                   
                    _rigidbody.freezeRotation = true;
                   
                }

                heldObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4));
            }
        }

       
    }
    
    
}

