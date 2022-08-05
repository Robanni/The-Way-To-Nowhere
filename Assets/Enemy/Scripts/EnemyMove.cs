using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : StateMachineBehaviour
{
    private float speed = 1f;
    private float attackRange;

    Transform  playerTransform;
    Rigidbody2D enemyRigidbody;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        enemyRigidbody = animator.GetComponent<Rigidbody2D>();
        attackRange = animator.GetComponent<Enemy_1>().AttackRange;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        Vector2 target = new Vector2(playerTransform.position.x, playerTransform.position.y);
        Vector2 movePossition = Vector2.MoveTowards(enemyRigidbody.position, target, speed * Time.fixedDeltaTime);

        enemyRigidbody.MovePosition(movePossition);

        if (Vector2.Distance(enemyRigidbody.transform.position, playerTransform.position)<= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }
}
