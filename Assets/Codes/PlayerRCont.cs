using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRCont : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;
    Rigidbody2D rb;

    public float fallMultiplier = 2.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(-movement, 0, 0) * Time.deltaTime * speed;

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.down * jumpForce;
        }

        //BetterJump
        if (rb.velocity.y > 0)
        {
            rb.velocity += Vector2.down * Physics2D.gravity.y * (fallMultiplier -1) * Time.deltaTime;
        }
        else if (rb.velocity.y < 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.down * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
