using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject bike;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = bike.transform.position - transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = bike.transform.position - offset;
        transform.forward = bike.transform.forward;     
    }
}
