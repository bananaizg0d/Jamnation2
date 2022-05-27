using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxR : MonoBehaviour
{
    BoxCollider2D bc;
    SpriteRenderer sr;
    bool boxActive = false;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        bc.enabled = false;
        sr.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (boxActive)
            {
                bc.enabled = false;
                sr.enabled = false;
                boxActive = false;
            }
            else
            {
                bc.enabled = true;
                sr.enabled = true;
                boxActive = true;
            }
        }

    }
}
