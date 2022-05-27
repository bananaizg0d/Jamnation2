using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxN : MonoBehaviour
{
    BoxCollider2D bc;
    SpriteRenderer sr;
    bool boxActive = true;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
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
