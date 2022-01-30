using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    float time;

    void Start()
    {   
        time = 60;
        timer.text = time.ToString();
        StartCoroutine(comienzo());

    }

    void Update()
    {
        timer.text = time.ToString();

        if(time == 0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }
    IEnumerator timerInGame()
    {
        yield return new WaitForSeconds(1);

        time -= 1; 
        StartCoroutine(timerInGame());

    }

    IEnumerator comienzo()
    {
        yield return new WaitForSeconds(6);
        StartCoroutine(timerInGame());

    }

}
