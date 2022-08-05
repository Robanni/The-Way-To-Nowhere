using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField]
    protected EnemyData enemyData;
    protected float attackRange;
    protected int maxHealth;
    protected int damage;

    public void ApplyEnemyData()
    {
        maxHealth = enemyData.MaxHealth;
        damage = enemyData.Damage;
        attackRange = enemyData.AttackRange;
        GetComponent<SpriteRenderer>().sprite = enemyData.Sprite;
    }
    public abstract void TakeDamage(int damage);

    public int MaxHealth { get { return maxHealth; } }
    public int Damage { get { return damage; } }
    public float AttackRange { get { return attackRange; } }
}
