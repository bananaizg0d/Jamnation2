using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNCont : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;
    Rigidbody2D rb;

    public float fallMultiplier = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        //BetterJump
        //if (rb.velocity.y < 0)
        //{
        //    rb.velocity+=Vector2.up * 
        //}
    }
}
