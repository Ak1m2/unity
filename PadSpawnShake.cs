
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadSpawnShake : MonoBehaviour
{
    public GameObject[] padSpawnPoints;
    int ShakeNumber;
    float Timer = 0.1f;
    void Start()
    {
        padSpawnPoints[0].SetActive(false);
        padSpawnPoints[1].SetActive(false);
        padSpawnPoints[2].SetActive(false);
        padSpawnPoints[3].SetActive(false);
    }

        void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0f)
        {
            Shake();
            Timer = 1f;
        }
    }

    private void Shake ()
    {
        ShakeNumber = Random.Range(0,4);
        for (int i = 0; i < 4; i++)
        {
            if (i == ShakeNumber)
            {
                padSpawnPoints[i].SetActive(true);
            }
            else 
            {
                padSpawnPoints[i].SetActive(false);
            }
        }
    }
}
