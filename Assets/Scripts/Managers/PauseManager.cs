using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] Canvas pauseCanvas;
    [SerializeField] Canvas reticleCanvas;
    [SerializeField] Canvas letterCanvas;

    void Start() 
    {
        pauseCanvas.enabled = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseCanvas.enabled == false) {
                openAudioUI();
            }
            else {
                closeAudioUI();
            }
        }
    }

    public void openAudioUI()
    {
        reticleCanvas.enabled = false;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        pauseCanvas.enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void closeAudioUI()
    {
        reticleCanvas.enabled = true;
        pauseCanvas.enabled = false;
        Time.timeScale = 1;
        FindObjectOfType<WeaponSwitcher>().enabled = true;
        FindObjectOfType<Weapon>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void openPauseFromLetter()
    {
        letterCanvas.enabled = false;
        pauseCanvas.enabled = true;
    }

    public void closeToMain()
    {
        pauseCanvas.enabled = false;
        letterCanvas.enabled = true;
    }
}
