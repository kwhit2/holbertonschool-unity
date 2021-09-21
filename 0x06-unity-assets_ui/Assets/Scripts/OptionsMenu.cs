using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public bool isInverted;
    public GameObject yInvertToggle;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("isYInverted") == 1)
        {
            yInvertToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
            isInverted = true;
        }
        else
        {
            yInvertToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            isInverted = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Back to previous scene
    public void Back()
    {
        int previous = PlayerPrefs.GetInt("Scene");
        SceneManager.LoadScene(previous);
    }

    // Apply Y invert
    public void Apply()
    {
        if (isInverted == true)
        {
            PlayerPrefs.SetInt("isYInverted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isYInverted", 0);
        }
    }

    // toggle invert
    public void Invert()
    {
        isInverted = !isInverted;
    }
}
