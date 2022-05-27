using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRCont : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;
    void Start()
    {

    }

    void Update()
    {
        //Movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(-movement, 0, 0) * Time.deltaTime * speed;

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * jumpForce;
        }
    }
}
