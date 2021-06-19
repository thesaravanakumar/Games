﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public Ball ball;
    public GameObject playerCamera;

    public float ballDistance=2f;
    public float ballThrowingForce = 5f;
    public bool holdingBall = true;
    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            if (Input.GetMouseButton(0))
            {
                holdingBall = false;
                ball.Activetrial();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward*ballThrowingForce);
            }
        }    
    }
}
