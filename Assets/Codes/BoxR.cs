using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxR : MonoBehaviour
{
    BoxCollider2D bc;
    bool boxActive = false;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        bc.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (boxActive)
            {
                bc.enabled = false;
                boxActive = false;
            }
            else
            {
                bc.enabled = true;
                boxActive = true;
            }
        }

    }
}
