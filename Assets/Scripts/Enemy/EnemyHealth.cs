using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] private AudioClip[] zombieHurtClips;
    [SerializeField] private AudioClip[] zombieDieClips;
    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }
    
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        SoundFXManager.instance.PlayRandomSoundFXCLip(zombieHurtClips, transform, 1f);
        hitPoints -= damage; 
        if (hitPoints <= 0)
        {
            SoundFXManager.instance.PlayRandomSoundFXCLip(zombieDieClips, transform, 1f);
            Die();
        }
    }

    void Die()
    {
        if (isDead) return;
    
        isDead = true;
        GetComponent<Animator>().SetTrigger("died");
        GetComponent<CapsuleCollider>().enabled = false;
    }
}
