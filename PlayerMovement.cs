using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    public Rigidbody Player;
    public float gravity = 50.0F;
    public Vector3 velocity;
    private bool walk, left, right, jump;
   
    //Distance from the Player to Ground
    public float distToGround = 2.28f;      



    void Start()
    {
        Player = this.GetComponent<Rigidbody>();

    }

    void Update()
    {

    }

    void FixedUpdate()
    {

        Debug.Log(isGrounded());

        CheckPlayerInput();


        UpdatePlayerPosition();

    }
    void UpdatePlayerPosition()
    {

        Vector3 pos = transform.localPosition;


        if (walk)
        {
            if (left)
            {
                pos.x -= velocity.x * Time.deltaTime;
            }
            if (right)
            {
                pos.x += velocity.x * Time.deltaTime;
            }
        }

        if (jump && isGrounded())
        {
            Player.AddForce(0, 200, 0);
        }

        if (!jump)
        {
            Player.AddForce(0, -50, 0);
        }



        transform.localPosition = pos;
    }


    void CheckPlayerInput()
    {

        bool input_left = Input.GetKey("left");
        bool input_right = Input.GetKey("right");
        bool input_up = Input.GetKey("up");

        walk = input_left || input_right;
        left = input_left && !input_right;
        right = input_right && !input_left;
        jump = input_up;



    }
    


    public bool isGrounded()
    {

        return Physics.Raycast(transform.position, Vector3.down, distToGround);

    }




}
