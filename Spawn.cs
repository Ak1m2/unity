using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] cloudPrefabs;

    private void Start()
    {
        SpawnCloud();
    }
    
    void SpawnCloud()
    {
        Instantiate(cloudPrefabs[Random.Range(0, cloudPrefabs.Length)], transform.position, Quaternion.identity);
        Invoke("SpawnCloud", Random.Range(0f, 10f)); 
    }
}
