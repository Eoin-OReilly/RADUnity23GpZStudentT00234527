using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControleScript : MonoBehaviour
{
    Rigidbody myRB;
    

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        



        if (Input.GetKey(KeyCode.W))
        {

             transform.position += transform.forward * Time.fixedDeltaTime;
        }

       if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -Time.fixedDeltaTime;
                }
        
        
        
        
        
        
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) 
        { 
            transform.Rotate(Vector3.up, -90 * Time.deltaTime); 
        }

       
        
      

        






    }

}
