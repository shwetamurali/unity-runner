﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin6script : MonoBehaviour {

    public GameObject player;
    public Rigidbody rigbo;
    public float speed = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //  transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    public void invokeMagnet3()
    {
        //transform.position = Vector3.MoveTowards(transform.position, player.position, 10 * Time.deltaTime);
        rigbo.AddForce(0, 800, 0);
        transform.Rotate(0, 360, 50000 * Time.deltaTime);
        //gameObject.SetActive(false);
        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}

