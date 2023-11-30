using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private int rayLength = 2;
    private bool cooldown = false;
    private Vector3 forward;
    private DoorController door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forward, out hit, rayLength))
        {
            if (!cooldown)
            {
                if (hit.collider.CompareTag("Door1"))
                {
                    door = hit.collider.gameObject.GetComponent<DoorController>();

                    if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.E))
                    {
                        door.PlayAnimation(1);
                        cooldown = true;
                        StartCoroutine(InteractionDelay());
                    }
                }
                else if (hit.collider.CompareTag("Door2"))
                {
                    door = hit.collider.gameObject.GetComponent<DoorController>();

                    if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.E))
                    {
                        door.PlayAnimation(2);
                        cooldown = true;
                        StartCoroutine(InteractionDelay());
                    }
                }
            }
        }
    }

    IEnumerator InteractionDelay()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
    }
}
