using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject pillar1;
    [SerializeField] private GameObject pillar2;
    [SerializeField] private Animation slidingAnimation;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip slidingClip;
    private bool animationDone = false;

    // Update is called once per frame
    void OnMouseDown()
    {
        if (!pillar1.activeInHierarchy && !pillar2.activeInHierarchy && !slidingAnimation.isPlaying && wall.activeInHierarchy)
        {
            source.PlayOneShot(slidingClip);
            slidingAnimation.Play("wallSlide");
            animationDone = true;



        }

        
    }

    void FixedUpdate()
    {
        if (!slidingAnimation.isPlaying && animationDone)
        {
            source.Stop();
        }
    }
}
