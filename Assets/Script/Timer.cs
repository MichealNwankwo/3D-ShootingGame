using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class Timer : MonoBehaviour
{
    public float timeValue=90;
    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue-=Time.deltaTime;
        }
       
        
         if (timeValue <= 0)
         {
             EditorApplication.isPlaying = false;
             Application.Quit();
         }

        DisplayTime(timeValue);
    }


    void DisplayTime(float timeToDisplay)
    {

        if(timeToDisplay <= 0 )
        {
            timeToDisplay=0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
