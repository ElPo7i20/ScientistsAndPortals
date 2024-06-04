using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private AudioSource jumpAud;
    PlayerInput input;
    [SerializeField] private Rigidbody2D rb;
    [Header("Jump")]
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask layerGround;
    [SerializeField] Transform overlapTransform;
    [SerializeField] private float jumpHeight, jumpWidth;
    private bool ground = false;
    [Header("MoveHorizontal")]
    [SerializeField] private AnimationCurve curveSpeed;
    [Header("Animation")]
    [SerializeField] private Animator animPlayer;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }
    public void Move(float direct, bool jumpPressed)
    {
        if (jumpPressed)
            Jump();
        if (Mathf.Abs(direct) > 0.01f)
            HorizontalMove(direct);
    }

    private void FixedUpdate()
    {
        ground = Physics2D.OverlapBox(overlapTransform.position, new Vector2 (jumpWidth, jumpHeight), 0, layerGround);
        AnimPlayerJump();
    }

    private void Jump()
    {
        if (ground)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpAud.Play();
        }
    }
    private void AnimPlayerJump()
    {
        if (ground)
        {
            input.mayFire = true;
            input.canUsePower = true;
            animPlayer.SetBool("Jump", false);
        }

        if (ground == false)
        {
            input.mayFire = false;
            input.canUsePower = false;
            animPlayer.SetBool("Jump", true);
        }
    }
    private void HorizontalMove(float direct)
    { 
        rb.velocity = new Vector2(curveSpeed.Evaluate(direct), rb.velocity.y);
        animPlayer.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));
        if (rb.velocity.x < -0.1f)
            spriteRenderer.flipX = true;
        if (rb.velocity.x > 0.1f)
            spriteRenderer.flipX = false;
    }    
}
