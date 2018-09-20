using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;
  
    public KeyCode jumpKey = KeyCode.Space;

    public float moveSpeed = 10f;

    SpriteRenderer sprite;
    Rigidbody2D rb;


    // Use this for initialization
    void Start () {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        float xSpeed = 0;

        if (Input.GetKey(rightKey)){
            xSpeed += moveSpeed;
            sprite.flipX = false;
        }

        if (Input.GetKey(leftKey))
            {
            xSpeed -= moveSpeed;
            sprite.flipX = true;
            }

        rb.velocity = new Vector2(xSpeed, rb.velocity.y); //dont move up
    }

        
}
