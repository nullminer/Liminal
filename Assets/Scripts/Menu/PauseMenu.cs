using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject a;
    bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggleActive();
        }
    }

    public void toggleActive()
    {
        if (isActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            a.SetActive(false);
            isActive = !isActive;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            a.SetActive(true);
            isActive = !isActive;
        }
    }
}
