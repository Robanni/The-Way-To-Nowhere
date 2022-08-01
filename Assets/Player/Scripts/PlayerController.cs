using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement
    public float speed = 0.1f;

    private Vector2 diraction;
    private Rigidbody2D playerRidgiedBody;

    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRidgiedBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerMovement();
    }

    private void playerMovement() 
    {
        diraction.x = Input.GetAxisRaw("Horizontal");
        diraction.y = Input.GetAxisRaw("Vertical");

        playerAnimator.SetFloat("Speed",Mathf.Abs (speed*diraction.x));//call run animation
        if(diraction.x == 0)playerAnimator.SetFloat("Speed",Mathf.Abs (speed*diraction.y));//call run animation

        if (diraction.x < 0) transform.rotation = Quaternion.AngleAxis(180,Vector3.up);//Changing rotation
        if (diraction.x > 0 ) transform.rotation = Quaternion.AngleAxis(0, Vector3.up);//of player sprite

        playerRidgiedBody.MovePosition(playerRidgiedBody.position + diraction * speed * Time.fixedDeltaTime);
        /*Taking position of player and adding diraction from keyboard multiplyed by speed and fixedDeltaTime*/
    }
}
