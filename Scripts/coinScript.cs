using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public Rigidbody rig;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void whenPicked()
    {
        rig.AddForce(0, 100, 0);
        Debug.Log("Spinning Up Effect");
    }
}
