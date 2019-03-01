using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jump = 500f;
    public bool isFalling = false;
    public GameObject cam;
    public PlayerMovement movement;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("up"))
        {
            if (rb.velocity.y >= -0.1)
            {
                Vector3 v = rb.velocity;
                v.y += .75f;
                rb.velocity = v;
                Invoke("goDown", .4f);
            }
            // rb.AddForce(0, 1, -.5f, ForceMode.VelocityChange);
            //isFalling = true;
        }
        if(Input.GetKey("down")) //shooting
        {
            RaycastHit hi;
            if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hi))
            {
                if(hi.transform.tag=="Coin")
                {
                    Debug.Log("Shot fired");
                    FindObjectOfType<PlayerCollisio>().addCoins();
                }
            }
        }

        if (transform.position.y<0)
        {
            FindObjectOfType<GameManager>().endGame();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Faster")
        {
            collision.collider.gameObject.SetActive(false);
            forwardForce = 9000f;
            Invoke("changeForceBack", 1);
        }

    }
    public void changeForceBack()
    {
        forwardForce = 2500f;
    }
    public void goDown()
    {
        Vector3 v = rb.velocity;
        v.y -= .7f;
        rb.velocity = v;
    }
    public void stopBall()
    {
        rb.velocity = new Vector3(0, 0, 0);
    }
    public void removeBall()
    {
        gameObject.SetActive(false);
    }
}
