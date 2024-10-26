using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }

        if(Input.GetKey("d")){
            rb.AddForce(Vector2.right * speed);
        }

        if(Input.GetKey("a")){
            rb.AddForce(Vector2.right * -speed);

        }

        if(rb.velocity.x >= maxspeed){
            rb.velocity = new Vector2(maxspeed, rb.velocity.y);
        }
        else if(rb.velocity.x <= -maxspeed){
            rb.velocity = new Vector2(-maxspeed, rb.velocity.y);
        }
        private bool isGrounded(){
            Vector2 center = transform.position - trnsform.up * 0.5f;
            float radius = 3f;

            if(physics2D.Overlap)
        }
        


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Teleporter")){
            SceneManager.LoadScene("Level2");
        }
    }
}
