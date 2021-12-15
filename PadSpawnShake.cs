using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadSpawnShake : MonoBehaviour
{
    public GameObject[] padSpawnPoints;
    void Start()
    {
        padSpawnPoints[0].SetActive(false);
        padSpawnPoints[1].SetActive(false);
        padSpawnPoints[2].SetActive(false);
        padSpawnPoints[3].SetActive(false);
    }

        void Update()
    {
        padSpawnPoints[Random.Range(0, padSpawnPoints.Length)].SetActive(true);
    }
}
