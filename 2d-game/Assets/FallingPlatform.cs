using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    Rigidbody2D rb;
    
    public float dropTime ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name.Equals("Player"))
        {
            Invoke("DropPlatform", dropTime);
            Destroy(gameObject, 1f);
        }
    }

     void DropPlatform()
    {
        rb.isKinematic = false;
    }

}
