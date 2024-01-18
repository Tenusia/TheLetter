using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    DisplayDamage damageFX;
    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        damageFX = FindObjectOfType<DisplayDamage>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.TakePlayerDamage(damage);
        damageFX.ShowDamageCanvas();
    }

}
