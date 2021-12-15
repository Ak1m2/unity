using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "CloudDelete")
        {
            Destroy(this.gameObject);
        }
       
        
    }
}
