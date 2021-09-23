using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

//PURPOSE:A UI Bar will be set the the mid center of the screen and visually represent time 
//USAGE: Place this on the image UI that has filled properties 
public class BreathTimerBehavior : MonoBehaviour
{
    Image timerBar;
    public float maxTime;
    public float timeLeft; 
    

    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime; 
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        { 
            //you can instantiate the lose screen here - like set active an animation or video 
            Time.timeScale = 0;
        }
    }
}
