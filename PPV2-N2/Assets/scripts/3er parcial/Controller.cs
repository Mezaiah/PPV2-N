using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using System;

public class Controller : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed
    public float jumpForce = 10f; // Adjust the jump force as needed
    private Rigidbody2D rb;
    bool IsJumping;
    bool Power;
    public GameObject origin;
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal axis (e.g., arrow keys or joystick)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the velocity based on the input and speed
        Vector2 velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        // Set the velocity of the Rigidbody2D
        rb.velocity = velocity;

        // Check for jump input (Z key)
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (IsJumping == false)
            {
                Jump();

            }
            if (Power == true)
            {
                IsJumping = false;
            }
            else
            {
                IsJumping = true;

            }
        }

      CheckJump();
        try
        {
            Power = true;
            Debug.Log("tienes el poder");
        }
        catch (Exception e)
        {
            new Exception("no tienes el poder");
            
            Debug.Log(e.Message);
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            IsJumping = false;
        }
        
        if (collision.gameObject.CompareTag("picos"))
        {
            rb.transform.position = origin.transform.position;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PowerUp"))
        {
             Power = true;
        }
    }

    bool CheckJump()
    {
        if (Power == false)
        {
            throw new Exception("No tienes el poder");
        }
        return Power;
    }
}