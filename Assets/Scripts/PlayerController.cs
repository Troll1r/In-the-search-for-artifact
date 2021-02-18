using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float Move;
    public float jump;
    float speed;
    public bool Grounded = false;
    public Transform GroundCheck;
    public float GroundRadius = 0.2f;
    public LayerMask WhatGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, WhatGround);
        if (Input.GetKey(KeyCode.D))
        {
            speed = Move;

            Vector3 Scaler = transform.localScale;
            Scaler.x = 16;
            transform.localScale = Scaler;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            speed = -Move;
            Vector3 Scaler = transform.localScale;
            Scaler.x = -16;
            transform.localScale = Scaler;

        }

        
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            rb.AddForce(new Vector2(0, jump),ForceMode2D.Impulse);

        }

        transform.Translate(speed, 0, 0);
        speed = 0;
    }



}
