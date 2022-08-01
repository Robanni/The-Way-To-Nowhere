using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //Attack
    public Transform attackPoint;
    public LayerMask enemyLayer;
    public float attackRange = 0.3f;

    private Animator playerAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) playerAttack();
    }

    private void playerAttack()
    {
        playerAnimator.SetTrigger("Attack");

        Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
    
        foreach(Collider2D enemy in hitEnemys)
        {
            Debug.Log("We hit" + enemy.name);
        }
    }
}
