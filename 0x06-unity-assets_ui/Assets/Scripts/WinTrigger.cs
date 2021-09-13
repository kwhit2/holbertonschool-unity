using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Timer>().enabled = false;
            other.gameObject.GetComponent<Timer>().TimerText.color = Color.green;
            other.gameObject.GetComponent<Timer>().TimerText.fontSize = 60;
        }
    }
}
