using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    public GameObject[] cube;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube[0].transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
        cube[1].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        cube[2].transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        cube[3].transform.Rotate(new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime));
    }
}
