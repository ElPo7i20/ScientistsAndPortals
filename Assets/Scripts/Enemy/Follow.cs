using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private const float IDLE = 0, FOLLOW = 1, RETURN = 2;
    [SerializeField] private Animator anim;
    [SerializeField] private float speed, distance, direction, rad;
    private float currentState;
    private Rigidbody2D rb;
    [SerializeField] private LayerMask lay;
    [SerializeField] private Transform target;
    private Vector2 stopPosition;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = 0;
        stopPosition = transform.position;
    }
    private void Update()
    {
        switch(currentState)
        {
            case IDLE:
                anim.SetFloat("Velocity", 0);
                Search();
                break;

            case FOLLOW:
                rb.position = Vector2.MoveTowards(transform.position, new Vector2 (target.position.x, transform.position.y), speed);
                anim.SetFloat("Velocity", 1);
                Search();
                break;

            case RETURN:
                rb.position = Vector2.MoveTowards(transform.position, new Vector2(stopPosition.x, transform.position.y), speed);
                transform.eulerAngles = new Vector3(0, 180, 0);
                anim.SetFloat("Velocity", 1);
                if (transform.position.x == stopPosition.x)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    currentState = 0;
                }    
                break;
        }
    }
    private void Search()
    {
        if(currentState == 0)
        {
            if (Physics2D.CircleCast(transform.position, rad, Vector2.left * direction, distance, lay))
            {
                currentState = 1;
            }
        }
        if (currentState == 1)
        {
            if (Physics2D.CircleCast(transform.position, rad, Vector2.left * direction, distance, lay))
            {
                currentState = 1;
            }
            else
            {
                currentState = 2;
            }
        }
    }
}
