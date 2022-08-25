using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelTimer : MonoBehaviour
{
    public int timelimit = 120;

    public Text Timertext;

    private float timeElapsed = 0.0f;

    public void Update()
    {
        timeElapsed += Time.deltaTime;
        Debug.Log(timeElapsed);
       int timeReaming = timelimit - (int)timeElapsed;

        if(timeReaming < 0)
        {
            timeReaming=0;
            SceneManager.LoadScene(0);
        }
        Timertext.text = timeReaming.ToString("00.00");
    }
}
