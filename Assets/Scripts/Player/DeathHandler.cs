using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] private AudioClip[] playerDeathClips;

    void Start() 
    {
        gameOverCanvas.enabled = false;    
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        // SoundFXManager.instance.PlayRandomSoundFXCLip(playerDeathClips, transform, 1f);
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
