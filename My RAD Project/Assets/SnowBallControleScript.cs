using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallControleScript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(2, 0, -4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(CubeControleScript cubeControleScript)
    {
        transform.position = cubeControleScript.transform.position;
    }
}
