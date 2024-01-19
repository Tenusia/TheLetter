using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngleAmount = 50f;
    [SerializeField] float restoreIntensityAmount = 10f;

    FlashLightSystem flashlight;
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag != "Player") {return;}
        else
        {
            flashlight = other.GetComponentInChildren<FlashLightSystem>();
            flashlight.RestoreLightAngle(restoreAngleAmount);
            flashlight.AddLightIntensity(restoreIntensityAmount);
            Destroy(gameObject);
        }       
    }
}
