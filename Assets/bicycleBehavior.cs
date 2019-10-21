using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bicycleBehavior : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public Quaternion offset;
    public float threshold;
    Vector3 direction;
    Rigidbody myBody;
    public GameObject handle;
    public float leftWeight;
    public float RightWeight;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        direction = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.2f;
        AccelMovement();
        //gyroMovement();
    }

    void gyroMovement()
    {
        Quaternion deviceRotation = GetRotation.Get();
        Vector3 convertedRotation = deviceRotation.eulerAngles;
       
        transform.rotation = Quaternion.Euler(0, 0, convertedRotation.z);
            
        if (Input.touchCount > 0)
        {
            Debug.Log(convertedRotation);

        }
    }

    void AccelMovement()
    {
        
        
            
            int speed =4;
             threshold = 0.2f;
             x = Input.acceleration.x;
             y = Input.acceleration.y;
            z = Input.acceleration.z;


    

        transform.Rotate(0, RightWeight - leftWeight +  2*speed * x, 0 );
        //this is where it gets fucked up.
      //  handle.transform.Rotate(0, RightWeight - leftWeight - 2 * speed * x, 0);

       

    }
    void setWeights(int a, string direction)
    {
        //set the offset quaternion to 0 or default.
    }
    

    
    void addWeights(int a, string direction)
    {
        //add or subtract things from Quaternion
     }


}
