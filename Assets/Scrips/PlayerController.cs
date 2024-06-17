using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerController pc;
    public PlayerController pc2;
    
    private new Rigidbody2D rigidbody;
    public float Speed;
    private float axisHorizontal;
    public float jumpForce;

    Vector3 startPo;
    Vector3 startPo1;

    public float distanceGround;
    public bool Grounded;

    public Transform foot;
    public Transform foot1;
    public Transform foot2;
    public LayerMask groundMask;

    //public GameObject oDeadPlayer;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        startPo = pc.transform.position;
        startPo1 = pc2.transform.position;

    }

    void Update()
    {
        axisHorizontal = Input.GetAxis("Horizontal");

        Debug.DrawRay(foot.position, Vector2.down * distanceGround, Color.red);
        Debug.DrawRay(foot1.position, Vector2.down * distanceGround, Color.red);
        Debug.DrawRay(foot2.position, Vector2.down * distanceGround, Color.red);

        if (Physics2D.Raycast(foot.position, Vector2.down, distanceGround, groundMask) || Physics2D.Raycast(foot1.position, Vector2.down, distanceGround, groundMask) || Physics2D.Raycast(foot2.position, Vector2.down, distanceGround, groundMask))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && Grounded == true)
        {
            rigidbody.AddForce(Vector2.up * jumpForce);
        }
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(axisHorizontal * Speed, rigidbody.velocity.y);
    }

    public void resetPosition()
    {
        if (pc.enabled == true)
        {
            pc.transform.position = startPo;
        }
        else
        {
            pc2.transform.position = startPo1;
        }

    }

    

}
