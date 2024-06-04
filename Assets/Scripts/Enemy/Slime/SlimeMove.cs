using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SlimeMove : MonoBehaviour
{
    private const float IDLE_STATE = 0, REVERT_STATE = 1, WALK_STATE = 2;
    private float currentState, currentTimeToRevert;
    [SerializeField] private float timeToRevert;
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer spRn;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        currentState = WALK_STATE;
        rb = GetComponent<Rigidbody2D>();
        currentTimeToRevert = 0;
    }
    private void Update()
    {
        if (currentTimeToRevert > timeToRevert)
        {
            currentState = REVERT_STATE;
            currentTimeToRevert = 0;
        }

        switch(currentState)
        {
            case WALK_STATE:
                rb.velocity = Vector2.up * speed;
                break;

            case IDLE_STATE:
                currentTimeToRevert += Time.deltaTime;
                rb.velocity = Vector2.zero;
                break;

            case REVERT_STATE:
                spRn.flipX = !spRn.flipX;
                speed *= -1;
                currentState = WALK_STATE;
                break;
        }
        anim.SetFloat("Velocity", rb.velocity.magnitude);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyStopper"))
        {
            currentState = IDLE_STATE;
        }
    }
}
