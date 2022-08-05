using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float attackRange;
    private int attackDamage;
    public Transform attackPoint;

    public LayerMask layerPlayers;
    protected EnemyData enemyData;

    private void Start()
    {
        attackDamage = GetComponent<Enemy_1>().Damage;
        attackRange = GetComponent<Enemy_1>().AttackRange;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6) // 6 это слой игрока Переделать позже для анимации
        {
            Attack();
        }
    }
    public void Attack()
    {
        Collider2D [] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, layerPlayers);

        foreach (Collider2D player in hitPlayers)
        {
            if(player != null)
            {
                player.GetComponent<PlayerController>().TakeDamage(attackDamage);
            }            
        }
    }
}
