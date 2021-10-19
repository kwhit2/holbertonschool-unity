using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEditor;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool isPaused;

    public AudioMixerSnapshot UnpausedNotMuffled;
    public AudioMixerSnapshot PauseMuffled;

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
        // muffle audio snapshot
        PauseMuffled.TransitionTo(.01f);
    }
    // Resume
    public void Resume()
    {
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);
        isPaused = false;
        // normal audio snapshot
        UnpausedNotMuffled.TransitionTo(.01f);
    }

    // To enable mouse in pause menu
    void OnGUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Restart
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Return to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Options
    public void Options()
    {
        SceneManager.LoadScene(1);
    }
}
