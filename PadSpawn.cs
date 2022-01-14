using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadSpawn : MonoBehaviour
{
    private float spawnPosition = 0f;
    public GameObject[] padPrefabs;
    [SerializeField] private Transform padSpawnPoint;
    Vector3 pos;
    
    void Start()
    {
        
        transform.position = padSpawnPoint.position;
    }

    
    void FixedUpdate()
    {
       pos = padSpawnPoint.position;
       pos.z = 0f;

        if (padSpawnPoint.position.y > spawnPosition + 1)
        {
            Spawn();
            spawnPosition = padSpawnPoint.position.y;
        }
    }
    private void Spawn()
        {
            Instantiate (padPrefabs[Random.Range(0, padPrefabs.Length)], pos, padSpawnPoint.transform.rotation);
        }
}
