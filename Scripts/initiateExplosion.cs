using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initiateExplosion : MonoBehaviour {

    public void Start()
    {
        gameObject.GetComponent<ParticleSystem>().enableEmission = false;
        gameObject.GetComponent<ParticleSystem>().Stop();
    }

    public void startEx()
    {
        gameObject.GetComponent<ParticleSystem>().enableEmission = true;

        gameObject.GetComponent<ParticleSystem>().Play();
    }
}
