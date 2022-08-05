using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : StateMachineBehaviour
{
    private float attackRange;
    private int attackDamage;
    private Transform attackPoint;

    public LayerMask layerPlayers;
    protected EnemyData enemyData;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
         attackDamage = animator.GetComponent<Enemy_1>().Damage;
        attackRange = animator.GetComponent<Enemy_1>().AttackRange;
        attackPoint = animator.gameObject.GetComponentInChildren<Transform>();
        Attack();
    }
    public void Attack()
    {
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, layerPlayers);

        foreach (Collider2D player in hitPlayers)
        {
            if (player != null)
            {
                player.GetComponent<PlayerController>().TakeDamage(attackDamage);
            }
        }
    }
/*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6) // 6 это слой игрока Переделать позже для анимации
        {
            Attack();
        }
    }*/
}
