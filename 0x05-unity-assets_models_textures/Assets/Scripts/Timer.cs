using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private Stopwatch timer = new Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        TimerText.text = timer.Elapsed.Minutes + ":" + timer.Elapsed.Seconds.ToString("00") + "." + timer.Elapsed.Milliseconds.ToString("00");
    }
}
