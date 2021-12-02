using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Saw : MonoBehaviour
{
    public float rotationSpeed, speed;
    public Transform pos1, pos2;
    private bool turnBack;


    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed);
        if (transform.position.x >= pos1.position.x)
        {
            turnBack = true;
        }
        if (transform.position.x <= pos2.position.x)
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
