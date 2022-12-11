using UnityEngine;

public class Pickup : MonoBehaviour
{
   [SerializeField] private GameObject curObject;

   [SerializeField] private Rigidbody curBody;

   [SerializeField] private Quaternion relRot;

 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) )
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
    }

    private void FixedUpdate()
    {
        if (curObject != null)
        {
            reposObject();
        }
    }

    private void reposObject()
    {
        float num = 2.5f;
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
        if (!(hitInfo.rigidbody == null) && hitInfo.transform.gameObject.layer == 10)
        {
            curBody = hitInfo.rigidbody;
            curBody.useGravity = false;
            curBody.constraints = RigidbodyConstraints.FreezeRotation;
            
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

