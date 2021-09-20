using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject Player;

    public GameObject WinCanvas;

    private Timer timerScript;

    // Start is called before the first frame update
    void Start()
    {
        timerScript = Player.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WinCanvas.SetActive(true);
            timerScript.Win();
            // other.gameObject.GetComponent<Timer>().enabled = false;
            // other.gameObject.GetComponent<Timer>().TimerText.color = Color.green;
            // other.gameObject.GetComponent<Timer>().TimerText.fontSize = 60;
        }
    }
}
