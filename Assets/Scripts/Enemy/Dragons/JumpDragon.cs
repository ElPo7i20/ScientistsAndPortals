using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpDragon : MonoBehaviour
{
    [SerializeField] private AudioSource jumpAud;
    private Rigidbody2D rb;
    private const float JUMP = 0, NOTHING = 1;
    private float currentState, directJump, currentTimeFall;
    [SerializeField] private float jumpForce, jumpRad, horVelocity, timeToFall;
    [SerializeField] private SpriteRenderer spriteR;
    [SerializeField] private Animator anim;
    [SerializeField] private LayerMask lay;
    private bool ground;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = 1;
        directJump = 1;
        currentTimeFall = timeToFall;
    }
    private void FixedUpdate()
    {
        ground = Physics2D.OverlapCircle(transform.position, jumpRad, lay);
    }
    private void Update()
    {
        switch(currentState)
        {
            case JUMP:
                rb.velocity = new Vector2(directJump * horVelocity, jumpForce);
                jumpAud.Play();
                currentState = 1;
                break;

            case NOTHING:
                if(ground && currentTimeFall > 0)
                {
                    currentTimeFall -= Time.deltaTime;
                    anim.SetBool("Jump", false);
                }
                if (currentTimeFall <= 0)
                {
                    spriteR.flipX = !spriteR.flipX;
                    directJump *= -1;
                    currentTimeFall = timeToFall;
                    anim.SetBool("Jump", true);
                    currentState = 0;
                }
                break;
        }
    }
}
