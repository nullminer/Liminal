using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayGeneration : MonoBehaviour
{
    public GameObject positiveHallway;
    public GameObject negativeHallway;
    private float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate()
    {
        z += 20.0f;
        Instantiate(positiveHallway, new Vector3(0, 0, 20.0f + z), Quaternion.identity);
        Instantiate(negativeHallway, new Vector3(0, 0, -20.0f - z), Quaternion.identity);
    }
}
