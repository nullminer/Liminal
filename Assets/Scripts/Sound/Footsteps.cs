using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource audioEffect;
    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != lastPosition)
        {
            audioEffect.UnPause();
        }
        else
        {
            audioEffect.Pause();
        }

        lastPosition = transform.position;
    }
}
