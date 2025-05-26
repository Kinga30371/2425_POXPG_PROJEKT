using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{

    public bool isGrounded;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //isGrounded = true;
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //isGrounded = false;
    //}

}
