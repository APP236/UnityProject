using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterMovement : MonoBehaviour
{
    public float Speed = 500F;
    private Animator animator;
    protected Vector2 direction;

    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    protected virtual void Update()
    {
        Move();
        direction = Vector2.zero;
    }
    protected void Move()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    public void AnimateMovement(Vector2 direction)
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }

}
