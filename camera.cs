using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform mainHero;
    Vector3 pos;
    
    void Start()
    {
        transform.position = mainHero.position;  
    }


    void Update()
    {
        pos = mainHero.position;
        pos.z = -10f;
        pos.x = 0f;
        transform.position = Vector3.Lerp(transform.position, pos, 1f * Time.deltaTime);
    }
}
