using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHero : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 1f;
    bool FacingRight = true;
    int directionInput;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector2 (speed * directionInput, rb.velocity.y);

        if (directionInput < 0 && FacingRight)
        {
            Flip();
        }
        else if (directionInput > 0 &&!FacingRight)
        {
            Flip();
        }
    }
    public void Move(int InputAxis)
    {
        directionInput = InputAxis;
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Platform") 
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * 4, ForceMode2D.Impulse);
        }
    }
}
