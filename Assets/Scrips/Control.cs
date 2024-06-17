
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Control pc;
    public Control pc2;
    public float speed;
    public Rigidbody2D rb;
    public float axisHorizontal;
    public float jumpForce;

    Vector3 iniPo;
    Vector3 iniPo2;

    public float distanceGround;
    public bool isGround;

    public Transform foot;
    public Transform foot1;
    public Transform foot2;
    public LayerMask groundMask;

    //public GameObject oDeadPlayer;
    //public AudioSource aSDeadPlayer;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        iniPo = pc.transform.position;
        iniPo2 = pc2.transform.position;
        //aSDeadPlayer = oDeadPlayer.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        axisHorizontal = Input.GetAxis("Horizontal");

        Debug.DrawRay(foot.position, Vector2.down * distanceGround, Color.red);
        Debug.DrawRay(foot1.position, Vector2.down * distanceGround, Color.red);
        Debug.DrawRay(foot2.position, Vector2.down * distanceGround, Color.red);

        if (Physics2D.Raycast(foot.position, Vector2.down, distanceGround, groundMask) || Physics2D.Raycast(foot1.position, Vector2.down, distanceGround, groundMask) || Physics2D.Raycast(foot2.position, Vector2.down, distanceGround, groundMask))
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }

        if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(axisHorizontal * speed, rb.velocity.y);
    }

    public void resetPosition()
    {
        if (pc.enabled == true)
        {
            pc.transform.position = iniPo;
        }
        else
        {
            pc2.transform.position = iniPo2;
        }

        //aSDeadPlayer.Play();
    }


    private void cambio()
    {

        if (pc.enabled == true)
        {

        }

    }


}
