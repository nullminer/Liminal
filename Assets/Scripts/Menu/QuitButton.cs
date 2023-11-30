using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button a;

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
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}