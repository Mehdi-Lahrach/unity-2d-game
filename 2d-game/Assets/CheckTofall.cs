using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTofall : MonoBehaviour
{
   public bool isStanding = false;


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            isStanding = true;
        }
    }
      
}
