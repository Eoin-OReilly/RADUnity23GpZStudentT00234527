using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonControle : MonoBehaviour
{
    float CurrentSpeed, WalkingSpeed = 2, RunningSpeed = 4;
    private float TurningSpeed = 180;




    // Start is called before the first frame update
    void Start()
    {
        CurrentSpeed = WalkingSpeed;







    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            myAnimation.SetBool("isWalking" = true);
            transform.position += CurrentSpeed * transform.forward * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.S)) 
        {
            transform.position -= CurrentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.D)) 
        {
            transform.Rotate(Vector3.up, TurningSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(Vector3.down, TurningSpeed * Time.deltaTime);
        }




    }
}
