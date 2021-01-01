using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    float mx;
    public float jumpforce = 12f;
    public float jumpstopper = .5f;
    public float dashforce = 60f;
    private PlayerControlMap playerControlMap;
    private float leftright;
    private float updown;
    private float dashtime=0f;
    public float dashadd=15f;
    private Vector2 dashvector;

    private void Awake()
    {
        playerControlMap = new PlayerControlMap();
    }
    private void OnEnable()
    {
        playerControlMap.Enable();
    }
    private void OnDisable()
    {
        playerControlMap.Disable();
    }
    // Update is called once per frame
    void Start()
    {
        playerControlMap.Land.Jump.started += _ => Jump();
        playerControlMap.Land.Jump.canceled += _ => shortHop();
        playerControlMap.Land.Dash.started += _ => ddash();
    }
    private void Update()
    {

        mx = playerControlMap.Land.Move.ReadValue<float>();
        leftright = playerControlMap.Land.LeftRight.ReadValue<float>();
        updown = playerControlMap.Land.UpDown.ReadValue<float>();

        if (dashtime>0)
        {
            dash();
            if (dashtime==0)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0f);
            }
        }
    }

    private void FixedUpdate()
    {
        if (dashtime <= 0)
        {
            Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
            rb.velocity = movement;
        }

        
    }
    void Jump()
    {
        //print("JUMPING");
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
    }
    void shortHop()
    {
        if(rb.velocity.y > 0)
        {
            print("canceling jump");
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y * jumpstopper));
        }
    }
    void ddash()
    {
        
        print("updown= " + updown + " leftright= " + leftright);
        print("dashing");
        //right
        if (leftright == 1 && updown ==0)
        {
            print("dashing right");
            dashvector = new Vector2(dashforce, .1f*rb.velocity.y);
        }
        //left
        else if (leftright == -1 && updown == 0)
        {
            print("dashing left");
            dashvector = new Vector2(-dashforce, .1f*rb.velocity.y);
        }
        //right and up
        else if (leftright == 1 && updown == 1)
        {
            print("dashing up right");
            dashvector = new Vector2(.707f*dashforce, .707f*dashforce);
        }
        //left and up
        else if (leftright == -1 && updown == 1)
        {
            print("dashing up left");
            dashvector = new Vector2(-.707f * dashforce, .707f * dashforce);
        }
        //up
        else if (leftright == 0 && updown == 1)
        {
            dashvector = new Vector2(0, .95f*dashforce);
        }
        //down
        else if (leftright == 0 && updown == -1)
        {
            dashvector = new Vector2(rb.velocity.x, -dashforce);
        }
        //right and down
        else if (leftright == 1 && updown == -1)
        {
            dashvector = new Vector2(.657f * dashforce, -.657f * dashforce);
        }
        //left and down
        else if (leftright == -1 && updown == -1)
        {
            dashvector = new Vector2(-.657f * dashforce, -.657f * dashforce);
        }
        dashtime += dashadd;
    }
    void dash()
    {
        dashtime -= 1;
        rb.velocity = dashvector;
    }
}
