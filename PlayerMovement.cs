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
    
    public HealthBar healthBar;
    public int maxHealth = 1000;
    public int currentHealth = 900 ;



    public HappinessBar happyBar;
    public int maxHappy = 500;
    public int currentHappy = 400;



    void Start()
    {
        Player = this.GetComponent<Rigidbody>();
        
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);


        happyBar.SetMaxHappiness(maxHappy);
        happyBar.SetHappiness(currentHappy);

    }

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        
        PosHealthRed();
    }
    
    private void OnTriggerEnter(Collider other) 
    {

        float x = transform.position.x;
        float y = transform.position.y;

        if ((other.name == "HealthIcon1"))
        {
            AddHealth(5);
 
        }

        else if ((other.name == "Moving"))
        {
            SubHealth(1);
            SubHappy(2);

        }

        else if((other.name == "HappinessCoin1"))
        {
            AddHappy(1);
        }

        else if((other.name == "Roller1"))
        {
            SubHealth(1);
        }
        //to add other objects, logical OR operator(||) can be used in the condition of if statements

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
    
    void SubHealth(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

    }

    void AddHealth(int add)
    {
        currentHealth += add;
        healthBar.SetHealth(currentHealth);
    }

    //HealthRed_Based_on_Position

    void PosHealthRed()
    {

        float x = Player.transform.position.x;
        float y = Player.transform.position.y;

        if (x > 1343 && x < 1345)
        {
            SubHealth(2);
        }



    }

    void SubHappy(int sad)
    {
        currentHappy -= sad;
        happyBar.SetHappiness(currentHappy);

    }

    void AddHappy(int happy)
    {
        currentHappy += happy;
        happyBar.SetHappiness(currentHappy);
    }




}
