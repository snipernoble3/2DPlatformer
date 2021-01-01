using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //decides player speed
    public float movementSpeed;
    public Rigidbody2D rb;
    //leftright direction for movement
    float mx;
    //decides jump height
    public float jumpforce = 12f;
    //decides how immediately jumps stop when short hopping
    public float jumpstopper = .5f;
    //decides how fast the dash is
    public float dashforce = 60f;
    //the controls
    private PlayerControlMap playerControlMap;
    //tracks left right aiming
    private float leftright;
    //tracks aiming up and down
    private float updown;
    //time before dash force is cut off
    private float dashtime=0f;
    //time added before dash force is cut off
    public float dashadd=15f;
    //could rework the two dash functions to remove this global variable
    private Vector2 dashvector;
    //keeps track of the direction the characters facing
    private float lastdirection;
    //marks if the player is grounded
    private bool grounded;
    //tracks dash to limit to 1
    //possibly change this to a decrementing number to allow more than one dash
    private bool hasdashed=false;
    //marks if there are walls to the left and/or right
    private bool wallleft=false;
    private bool wallright=false;
    //how much time should the player not be able to change direction while walljumping
    public float walljumptime = 40;
    //when this timer is active the player isnt able to overide velocity with direction inputs
    private float controltimer=0;
    //size of character
    Vector2 boxSize = new Vector2(1f, 1f);

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
    //sets the button listeners
    void Start()
    {
        playerControlMap.Land.Jump.started += _ => Jump();
        playerControlMap.Land.Jump.canceled += _ => shortHop();
        playerControlMap.Land.Dash.started += _ => ddash();
        
    }
    // Update is called once per frame
    private void Update()
    {
        //keeps track of movement input
        mx = playerControlMap.Land.Move.ReadValue<float>();
        leftright = playerControlMap.Land.LeftRight.ReadValue<float>();
        updown = playerControlMap.Land.UpDown.ReadValue<float>();
        if(isGrounded()&&dashtime==0)
        {
            hasdashed = false;
        }
        if (dashtime>0)
        {
            //dash();
            dashtime -= 1;
            if (dashtime==0)
            {
                rb.velocity = new Vector2(.2f*rb.velocity.x, .2f* rb.velocity.y);
            }
        }
        if (controltimer>0)
        {
            controltimer--;
        }
        
    }

    private void FixedUpdate()
    {
        //if the character is not mid dash and has control takes character movement
        if (dashtime <= 0&&controltimer<=0)
        {
            if (mx > 0.375f || mx <-0.375f)
            {
                //keeps track of this for if a dash is performed while no directional input is happening
                lastdirection = mx;
            
                //sets velocity towards mx at movement speed
                Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
                rb.velocity = movement;
            }
        }

        
    }

    //jumps and wall jumps
    void Jump()
    {
        grounded = isGrounded();
        print("JUMPING Grounded= " + grounded);
        //if on the ground can jump
        if (grounded==true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
        //if not on the ground but is next to a wall can wall jump
        else if(isWall())
        {
            //take away control for a breif interval
            controltimer = walljumptime;
            //jumps straight up if squeezed between 2 walls
            if(wallleft&&wallright)
            {
                rb.velocity = new Vector2(rb.velocity.x, .75f*jumpforce);
            }
            //otherwise jump away from wall
            else if(wallleft)
            {
                rb.velocity = new Vector2(17.5f, .75f * jumpforce);
            }
            else if (wallright)
            {
                rb.velocity = new Vector2(-17.5f, .75f * jumpforce);
            }
        }
    }

    //cancels a jump if released early
    void shortHop()
    {
        if(rb.velocity.y > 0)
        {
            print("canceling jump");
            rb.velocity = new Vector2(rb.velocity.x, (rb.velocity.y * jumpstopper));
        }
    }

    //sets the dash direction vector
    void ddash()
    {
        
        if (hasdashed == false)
        {
            hasdashed = true;
            print("updown= " + updown + " leftright= " + leftright);
            print("lastdirection= " + lastdirection);
            print("dashing");
            //right
            //the weird floats in the if statements are trying to account for dead zones
            if (leftright > 0.10f && (updown <= .35f && updown >= -.35f))
            {
                print("dashing right");
                dashvector = new Vector2(dashforce, 1f);// .04f*rb.velocity.y);
            }
            //left
            else if (leftright < -0.10f && (updown <= .35f && updown >= -.35f))
            {
                print("dashing left");
                dashvector = new Vector2(-dashforce, 1f);// .04f*rb.velocity.y);
            }
            //right and up
            else if (leftright > 0.35f && updown > 0.35f)
            {
                print("dashing up right");
                dashvector = new Vector2(.607f * dashforce, .777f * dashforce);
            }
            //left and up
            else if (leftright < -0.35f && updown > 0.35f)
            {
                print("dashing up left");
                dashvector = new Vector2(-.607f * dashforce, .777f * dashforce);
            }
            //up
            else if ((leftright <= .35f && leftright >= -.35f) && updown > 0.35f)
            {
                dashvector = new Vector2(0, .95f * dashforce);
            }
            //down
            else if ((leftright <= .35f && leftright >= -.35f) && updown < -0.35f)
            {
                dashvector = new Vector2(rb.velocity.x, -dashforce);
            }
            //right and down
            else if (leftright > 0.35f && updown < -0.35f)
            {
                dashvector = new Vector2(.657f * dashforce, -.657f * dashforce);
            }
            //left and down
            else if (leftright < -0.35f && updown < -0.35f)
            {
                dashvector = new Vector2(-.657f * dashforce, -.657f * dashforce);
            }
            //if no directional input was given dashes the way the player last moved/the way the player is facing
            else
            {
                if (lastdirection > 0)
                {
                    dashvector = new Vector2(dashforce, .1f * rb.velocity.y);
                }
                else if (lastdirection < 0)
                {
                    dashvector = new Vector2(-dashforce, .1f * rb.velocity.y);
                }
            }
            dashtime += dashadd;
            //testing
            dash();
        }
    }
    //sets dash velocity
    void dash()
    {
        //dashtime -= 1;
        rb.velocity = dashvector;
    }

    //checks if player is on the ground
    private bool isGrounded()
    {
        // debugging message //print("Position: " + transform.position);

        // casts ray down to check for platform
        //return Physics2D.Raycast(transform.position, Vector2.down, .6f + .1f);
        
        return Physics2D.BoxCast(transform.position,boxSize, 0f, Vector2.down, .6f + .1f);
    }
    
    //checks if next to a wall
    //might need improvement cuz it checks from middle of body, might be better from different point
    private bool isWall()
    {
        wallleft = false;
        wallright = false;
        //checks for left and right wall
        wallleft=Physics2D.BoxCast(transform.position, boxSize, 0f, Vector2.left, .7f + .1f);
        wallright=Physics2D.BoxCast(transform.position, boxSize, 0f, Vector2.right, .7f + .1f);
        //wallleft =Physics2D.Raycast(transform.position, Vector2.left, .7f + .1f);
        //wallright=Physics2D.Raycast(transform.position, Vector2.right, .7f + .1f);
        return (wallleft||wallright);
        
    }
}
