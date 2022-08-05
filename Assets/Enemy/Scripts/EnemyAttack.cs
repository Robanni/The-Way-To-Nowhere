using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange = 0.4f;
    public Transform attackPoint;

    public LayerMask layerPlayers;
    protected EnemyData enemyData;

    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6) // 6 ��� ���� ������ ���������� ����� ��� ��������
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
                player.GetComponent<PlayerController>().TakeDamage(3);
            }
            
        }
    }

}
