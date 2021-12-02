using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radarscript : MonoBehaviour
{
   public bool move = false;
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("player"))
        {
            move = true;
        }

    }
}
