using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    private float maxHealth;
    public HealthBar healthBar;

    private void Start() {
        maxHealth = hitPoints;
        healthBar.SetMaxHealth(hitPoints);
    }
    
    public void TakePlayerDamage(float damage)
    {
        hitPoints -= damage;
        healthBar.SetHealth(hitPoints);

        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

    public void IncreaseHealth(float health) {
        hitPoints += health;
        if (hitPoints > maxHealth) {
            hitPoints = maxHealth;
        }
        healthBar.SetHealth(hitPoints);
    }
}
