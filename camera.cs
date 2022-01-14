using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
   public Transform mainHero;
   Vector3 pos;
   public GameObject pausedScreen;
   bool pausePanel = false;

    void Start()
    {
        pausedScreen.SetActive(pausePanel);
        transform.position = mainHero.position;  
    }


    void Update()
    {
        pos = mainHero.position;
        pos.z = -10f;
        pos.x = 0f;
        transform.position = Vector3.Lerp(transform.position, pos, 1f * Time.deltaTime);
    }

    public void gamePaused()
    {
        if (!pausePanel)
        {
            Time.timeScale = 0;
            pausePanel = true;
            pausedScreen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel = false;
            pausedScreen.SetActive(false);
        }
    }
}
