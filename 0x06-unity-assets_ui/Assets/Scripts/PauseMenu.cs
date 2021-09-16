using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Pause();
        }

        else
        {
            Resume();
        }
    }

    // Pause Menu
    public void Pause()
    {
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
    }
    // Resume
    public void Resume()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        isPaused = false;
    }

    // To enable mouse in pause menu
    void OnGUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
