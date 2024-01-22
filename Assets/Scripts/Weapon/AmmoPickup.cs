using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;
    [SerializeField] AmmoType ammoType;
    [SerializeField] private AudioClip itemPickUpClip;

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            SoundFXManager.instance.PlaySoundFXCLip(itemPickUpClip, transform, 1f);
            Destroy(gameObject);
        }
    }
}
