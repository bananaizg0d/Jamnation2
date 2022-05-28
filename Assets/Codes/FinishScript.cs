using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] bool PlayerN;
    [SerializeField] bool PlayerR;
    public LayerMask playerMask;
    string PlayerNorm;

    void Start()
    {

    }

    void Update()
    {
        Physics2D.OverlapBox(transform.position, transform.localScale, 0);
        MyCollisions();
        if (PlayerN && PlayerR)
        {

        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }

    public void MyCollisions()
    {
        //Collider2D[] hitColliders = Physics2D.OverlapBoxAll(transform.position, transform.localScale,0);
        //foreach(Collider2D collider)

    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("aha girdi");
    //    if (other.name.Contains("PlayerNorm"))
    //        {
    //            PlayerN = true;
    //        }
    //    if (other.name.Contains("PlayerReverse"))
    //        {
    //            PlayerR = true;
    //        }
    //}
    //public void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("aha çikti");
    //    if (other.name.Contains("PlayerNorm"))
    //        {
    //            PlayerN = false;
    //        }
    //    if (other.name.Contains("PlayerReverse"))
    //        {
    //            PlayerR = false;
    //        }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aha girdi");
        if (collision.name.Contains("PlayerNorm"))
        {
            PlayerN = true;
        }
        if (collision.name.Contains("PlayerReverse"))
        {
            PlayerR = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("aha cikti");
        if (collision.name.Contains("PlayerNorm"))
        {
            PlayerN = false;
        }
        if (collision.name.Contains("PlayerReverse"))
        {
            PlayerR = false;
        }
    }


}
