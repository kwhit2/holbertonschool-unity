using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool isInverted = false;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isYInverted") == 1)
        {
            isInverted = true;
        }
        else
        {
            isInverted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Invert mouse controls
        if (isInverted)
        {
            var MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 40.0f;
            transform.Rotate(-MouseY, 0, 0);
        }
    }
}
