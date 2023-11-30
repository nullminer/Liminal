using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;
    private bool isOpen = false;
    public HallwayGeneration hallway;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation(int animationNumber)
    {
        if (animationNumber == 1)
        {
            if (!isOpen)
            {
                doorAnimator.Play("DoorOpen1", 0, 0.0f);
                isOpen = true;
                hallway.Generate();
            }
            else
            {
                doorAnimator.Play("DoorClose1", 0, 0.0f);
                isOpen = false;
            }
        }
        else
        {
            if (!isOpen)
            {
                doorAnimator.Play("DoorOpen2", 0, 0.0f);
                isOpen = true;
                hallway.Generate();
            }
            else
            {
                doorAnimator.Play("DoorClose2", 0, 0.0f);
                isOpen = false;
            }
        }

        // random generation
    }
}
