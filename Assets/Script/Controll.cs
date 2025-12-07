using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Controll : MonoBehaviour
{
    public Rigidbody rig;
    public float speed = 5f;
    public float jumpforce;
    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        Vector3 vel = rig.velocity;
        vel.y = 0;
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        transform.forward = rig.velocity;

        transform.forward = vel;

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            rig.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal == Vector3.up)
        {
            isGround = true;
        }
    }
}
