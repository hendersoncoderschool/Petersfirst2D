using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float JumpForce;
    public float speed;

    public float maxspeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
        }

        if(Input.GetKey("d")){
            rb.AddForce(transform.right * speed);
        }

        if(Input.GetKey("a")){
            rb.AddForce(transform.right * -speed);

        }

        if(rb.velocity.x >= maxspeed){
            rb.velocity = new Vector2(maxspeed, rb.velocity.y);
        }
        else if(rb.velocity.x <= -maxspeed){
            rb.velocity = new Vector2(-maxspeed, rb.velocity.y);
        }

        


    }
}
