using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector2 diraction;
    private Rigidbody2D playerRidgiedBody;
    // Start is called before the first frame update
    void Start()
    {
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

        playerRidgiedBody.MovePosition(playerRidgiedBody.position + diraction * speed * Time.fixedDeltaTime);
        /*Taking position of player and adding diraction from keyboard multiplyed by speed and fixedDeltaTime*/
    }
}
