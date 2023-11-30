using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public Button a;
    public PauseMenu pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Button b = a.GetComponent<Button>();
        b.onClick.AddListener(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void c()
    {
        pauseMenu.toggleActive();
    }
}
