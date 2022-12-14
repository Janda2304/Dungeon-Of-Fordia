using UnityEngine;

public class Pickup : MonoBehaviour
{
    private GameObject curObject;

    private Rigidbody curBody;

    private Quaternion relRot;

  
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (curObject == null)
            {
                pickupItem();
            }
            else
            {
                dropItem();
            }
        }
        
        if (curObject != null)
        {
            reposObject();
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void reposObject()
    {
        float num = 4.25f;
        if (base.transform.forward.y < -0.7f)
        {
            num = 2f;
        }
        Vector3 vector = base.transform.position + base.transform.forward * num;
        Quaternion rotation = base.transform.rotation * relRot;
        curBody.velocity = (vector - curBody.position) * 10f;
        curBody.rotation = rotation;
        curBody.angularVelocity = Vector3.zero;
    }

    private void pickupItem()
    {
        Physics.Raycast(base.transform.position, base.transform.forward, out var hitInfo, 5f);
        if (!(hitInfo.rigidbody == null) && hitInfo.transform.gameObject.tag == "Pickup")
        {
            curBody = hitInfo.rigidbody;
            curBody.useGravity = false;
            curObject = hitInfo.rigidbody.gameObject;
            curObject.transform.parent = base.transform;
            relRot = curObject.transform.localRotation;
            curObject.transform.parent = null;
        }
    }

    private void dropItem()
    {
        curBody.useGravity = true;
        curBody = null;
        curObject = null;
    }

    public bool isHolding()
    {
        return curObject != null;
    }
}


