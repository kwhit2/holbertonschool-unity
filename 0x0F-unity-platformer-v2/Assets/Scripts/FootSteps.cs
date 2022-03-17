using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    CharacterController cc;

    public AudioSource footsteps_running_grass;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        footsteps_running_grass = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && footsteps_running_grass.isPlaying == false)
        {
            // footsteps
            footsteps_running_grass.Play();
        }
    }
}
