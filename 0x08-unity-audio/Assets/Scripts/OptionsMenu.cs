using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public bool isInverted;
    public GameObject yInvertToggle;

    public AudioMixer BGM;
    public AudioMixer SFX;

    public Slider BGMSlider;
    public Slider SFXSlider;

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
        BGMSlider.value = PlayerPrefs.GetFloat("BGMVol", 0.75f);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVol", 0.75f);
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

    // BGM slider audio toggle
    public void SetBGMToggle(float sliderValue)
    {
        BGM.SetFloat("BGMVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGMVol", sliderValue);
    }

    // SFX slider audio toggle
    public void SetSFXToggle(float sliderValue)
    {
        SFX.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVol", sliderValue);
    }
}
