﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Ball ball;
    public float rotation;
    public bool gameHasStarted = false;

    /// <summary>
    /// Call on first frame
    /// </summary>
    private void Start()
    {
        rb2d.GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Deals with the changing the rotation of the trajectory
    /// </summary>
    void FixedUpdate()
    {
        bool movementRight = Input.GetKey(KeyCode.D);
        bool movementLeft = Input.GetKey(KeyCode.A);

        //If movement right set set new angle of trajectory to the right
        if (movementRight)
        {
            rb2d.gameObject.transform.Rotate(new Vector3(0, 0, -1), Space.World);
            rotation = gameObject.transform.rotation.z;
        }
        

        //If movement left set set new angle of trajectory to the left
        else if (movementLeft)
        {
            rb2d.gameObject.transform.Rotate(new Vector3(0, 0, 1), Space.World);
            rotation = gameObject.transform.rotation.z;
        }

        if (ball.gameHasStarted == true)
        {
<<<<<<< HEAD
            gameObject.SetActive(false);
=======
            rb2d.transform.eulerAngles = new Vector3(0, 0, 0);
>>>>>>> master
        }
    }
}

