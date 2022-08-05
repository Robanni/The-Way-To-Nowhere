using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : StateMachineBehaviour
{
    private float speed = 1f;

    Transform  playerPossition;
    Rigidbody2D enemyRigidbody;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPossition = GameObject.FindGameObjectWithTag("Player").transform;
        enemyRigidbody = animator.GetComponent<Rigidbody2D>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        Vector2 target = new Vector2(playerPossition.position.x, playerPossition.position.y);
        Vector2 movePossition = Vector2.MoveTowards(enemyRigidbody.position, target, speed * Time.fixedDeltaTime);

        enemyRigidbody.MovePosition(movePossition);
    }
}
