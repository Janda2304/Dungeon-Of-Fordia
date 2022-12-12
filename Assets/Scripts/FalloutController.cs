using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FalloutController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Vector3 startPosition = new Vector3(20.4f, 3f, 7.52f);
    public Vector3 tunnelPosition = new Vector3();
    

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(20.4f, 3f, 7.52f);
    }
}
