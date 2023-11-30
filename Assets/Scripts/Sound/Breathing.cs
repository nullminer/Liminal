using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{
    public AudioSource audioEffect;

    private bool isPlaying = false;
    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == false)
        {
            randomInt = Random.Range(1, 10000);

            if (randomInt == 1)
            {
                audioEffect.Play();

                isPlaying = true;
                StartCoroutine(SetFalse());
            }
        }
    }

    IEnumerator SetFalse() {
        yield return new WaitForSeconds(10);
        isPlaying = false;
    }
}
