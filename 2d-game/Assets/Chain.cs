using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject chektofall;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

   
    void Update()
    {
       if(chektofall.GetComponent<CheckTofall>().isStanding)
        {
            Invoke("Drop", 0.3f);
        }


    }

    void Drop()
    {
        rb.isKinematic = false;
    }

}
