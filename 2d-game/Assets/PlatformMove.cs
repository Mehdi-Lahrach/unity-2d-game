using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public GameObject radar;
    private bool condition = true;
    public Vector2 PlatformPosition;

   

  
    void Update()
    {
        if(condition && radar.GetComponent<Radarscript>().move)
        {
            transform.position = PlatformPosition;
            condition = false;
        }
    }
}
