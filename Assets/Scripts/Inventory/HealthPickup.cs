using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] float restoreHealthAmount = 50;
    [SerializeField] private AudioClip itemPickUpClip;

    PlayerHealth playerHealth;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Player") {return;}
        else
        {
            SoundFXManager.instance.PlaySoundFXCLip(itemPickUpClip, transform, 1f);
            playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.IncreaseHealth(restoreHealthAmount);
            Destroy(gameObject);
        }   
    }
}
