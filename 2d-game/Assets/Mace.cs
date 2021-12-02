using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mace : MonoBehaviour
{
    public float walkspeed;
    [HideInInspector]
    public bool mustPatrol;
    public bool mustTurn;
    

    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    
    void Start()
    {
        mustPatrol = true;
    }

    void Update()
    {
        if(mustPatrol){
            Patrol();
        }
    }


    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }

    }
    void Patrol()
    {
        if(mustTurn)
        {
            flip();
        }
        rb.velocity = new Vector2(walkspeed * Time.fixedDeltaTime, rb.velocity.y);
    }


    void flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkspeed *= -1;
        mustPatrol = true;
    }

   


    void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.CompareTag("Wall")) //if the mace colide with wall he flips
        {
            flip();
        }
    }



}

