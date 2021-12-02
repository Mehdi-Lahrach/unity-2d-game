using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public float speed;
    public Transform pos1, pos2;
    private bool turnBack;



    void Update()
    {
       
        if (transform.position.y >= pos1.position.y)
        {
            turnBack = true;
        }
        if (transform.position.y <= pos2.position.y)
        {
            turnBack = false;
        }

        if (turnBack)
        {
            transform.position = Vector2.MoveTowards(transform.position, pos2.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pos1.position, speed * Time.deltaTime);
        }


    }
}
