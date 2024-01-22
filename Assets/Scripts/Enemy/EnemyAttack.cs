using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    DisplayDamage damageFX;
    [SerializeField] float damage = 40f;
    [SerializeField] private AudioClip[] zombieAttackClips;
    [SerializeField] private AudioClip[] playerHitClips;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        damageFX = FindObjectOfType<DisplayDamage>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        SoundFXManager.instance.PlayRandomSoundFXCLip(zombieAttackClips, transform, 1f);
        target.TakePlayerDamage(damage);
        SoundFXManager.instance.PlayRandomSoundFXCLip(playerHitClips, transform, 1f);
        damageFX.ShowDamageCanvas();
    }

}
