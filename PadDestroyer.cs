using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadDestroyer : MonoBehaviour
{
    public GameObject destroyPoint;
     void Start()
    {
        destroyPoint = GameObject.Find("PadDelete");
    }

    void Update()
    {
        if (transform.position.y < destroyPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
