using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : BaseEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        ApplyEnemyData();
        
    }

    
    public override void TakeDamage(int damage)
    {
        maxHealth -= damage;
        if (maxHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    

}
