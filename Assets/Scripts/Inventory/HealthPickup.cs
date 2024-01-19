using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] float restoreHealthAmount = 50;

    PlayerHealth playerHealth;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Player") {return;}
        else
        {
            playerHealth = other.GetComponent<PlayerHealth>();
            playerHealth.IncreaseHealth(restoreHealthAmount);
            Destroy(gameObject);
        }   
    }
}
