using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    public float Speed;
    private float axisHorizontal;
    public float jumpForce;
    private bool Grounded;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {


    }

    void Update()
    {
        axisHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            rigidbody.AddForce(Vector2.up * jumpForce);
        }

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.8f))
        {
            Grounded = true;
        }
        else
        {
            Grounded= false;
        }
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(axisHorizontal * Speed, rigidbody.velocity.y);
    }

}
