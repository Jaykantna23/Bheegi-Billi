using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsController : MonoBehaviour
{
    public Canvas MainSettings;
    public Canvas AudioSettings;
    public Canvas Speed;
    void Start()
    {
        MainSettings.gameObject.SetActive(true);
        AudioSettings.gameObject.SetActive(false);
        Speed.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ShowSoundSettings()
    {
        MainSettings.gameObject.SetActive(false);
        AudioSettings.gameObject.SetActive(true);
        Speed.gameObject.SetActive(false);
    }
    public void ShowSpeedSettings()
    {
        MainSettings.gameObject.SetActive(false);
        AudioSettings.gameObject.SetActive(false);
        Speed.gameObject.SetActive(true);
    }
    public void Back()
    {
        MainSettings.gameObject.SetActive(true);
        AudioSettings.gameObject.SetActive(false);
        Speed.gameObject.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
