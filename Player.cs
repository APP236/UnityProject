using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterMovement
{
    //Rigidbody2D rbody;
    Animator anim;
    void Start()
    {
       // rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    protected override void Update()
    {
        Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        if (movementVector!=Vector2.zero)
	{
            anim.SetBool("IsWalking",true);
            anim.SetFloat("InputX",movementVector.x);
            anim.SetFloat("InputY",movementVector.y);

	}
        else
	{
             anim.SetBool("IsWalking",false);
	}


        
        GetInput();
        base.Update(); 
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

}
