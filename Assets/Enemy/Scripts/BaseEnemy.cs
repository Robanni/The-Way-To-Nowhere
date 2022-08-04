using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField]
    protected EnemyData enemyData;

    protected int maxHealth;
    protected int damage;


    private void Start()
    {
        
    }

    public void ApplyEnemyData()
    {
        maxHealth = enemyData.MaxHealth;
        damage = enemyData.Damage;
        GetComponent<SpriteRenderer>().sprite = enemyData.Sprite;
    }
    public abstract void TakeDamage(int damage);  
}
