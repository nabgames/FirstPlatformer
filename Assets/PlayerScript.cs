using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Rigidbody2D rb;
    public float jumpSpeed;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        float below_distance = 1.2f;  // radius of player plus a little         Vector3 down = new Vector3(transform.position.x, transform.position.y - below_distance, 0.0f);
        onGround = Physics2D.OverlapCircle(down, groundCheckRadius, whatIsGround);
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + move * .13f;
        if (Input.GetKeyDown(KeyCode.Space)&& onGround||Input.GetKeyDown(KeyCode.W)&& onGround){
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        if (Input.GetKey(KeyCode.S)&& onGround==false){
            rb.velocity = new Vector2(rb.velocity.x, -jumpSpeed);
        }
	}
}
