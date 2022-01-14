using UnityEngine;

public class MainHero : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 1f;
    bool FacingRight = true;
    int directionInput;
    private camShake shake;
    int jumpForce = 4;
    bool buttonPressed = false;
    

    
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<camShake>();
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
        if (buttonPressed == true)
        {
           rb.velocity = new Vector2 (rb.velocity.x, 1f);
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
        if (other.gameObject.tag == "Platform" & buttonPressed == false) 
        {
            jumpForce = 4;
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);

        }
        if (other.gameObject.tag == "PlatformShake" & buttonPressed == false) 
        {
            jumpForce = 4;
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            shake.Shake();

        }
    }
    public void JetPackEnabled()
    {
        buttonPressed = true;
    }
    public void JetPackDisabled()
    {
        buttonPressed = false;
    }
}
