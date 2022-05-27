using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxN : MonoBehaviour
{
    BoxCollider2D bc;
    bool boxActive = true;
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
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
