using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerText;

    float elapsedTime;

    private TimeSpan activeTime;

    public Text FinalTime;

    // goes with commented out Stopwatch code in the Update method
    // private Stopwatch timer = new Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        // was to start Stopwatch but could not get milliseconds to 2 decimal places
        // timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        activeTime = TimeSpan.FromSeconds(elapsedTime);
        string activeTimeStr = activeTime.ToString("mm':'ss'.'ff");
        TimerText.text = activeTimeStr;
        // could not get timer to display 2 decimal places for milliseconds this way
        // TimerText.text = timer.Elapsed.Minutes + ":" + timer.Elapsed.Seconds.ToString("00") + "." + timer.Elapsed.Milliseconds.ToString("00");
    }

    public void Win()
    {
        // when the player touches the flag, the player’s finish time is displayed in FinalTime in WinCanvas
        activeTime = TimeSpan.FromSeconds(elapsedTime);
        string activeTimeStr = activeTime.ToString("mm':'ss'.'ff");
        FinalTime.text = activeTimeStr;
        GetComponent<Timer>().TimerText.enabled = false;
    }
}
