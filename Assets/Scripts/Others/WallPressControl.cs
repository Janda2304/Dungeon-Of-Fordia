using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WallPressControl : MonoBehaviour
{
    [SerializeField] private Animator _animator1;
    [SerializeField] private Animator _animator2;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    [SerializeField] private GameObject deathScreen;

    // Update is called once per frame
    void FixedUpdate()
    {
        _animator1.Play("Base Layer.wallLeftPress");
        _animator2.Play("Base Layer.wallRightPress");
        StartCoroutine(Delay());

  

    }


    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.5f);
        source.PlayOneShot(clip);
        yield return new WaitForSeconds(3f);


    }
    
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
        }
    }
}
