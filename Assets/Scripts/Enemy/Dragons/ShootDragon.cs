using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDragon : MonoBehaviour
{
    [SerializeField] public float shootDistance;
    [SerializeField] private LayerMask lay;
    [SerializeField] private SpriteRenderer spR;
    private float shootDirection;
    [SerializeField] private Animator anim;

    private void Update()
    {
        if (spR.flipX == false)
            shootDirection = 1;
        if(spR.flipX == true)
            shootDirection = -1;
        if (Physics2D.Raycast(transform.position, Vector2.right * shootDirection, shootDistance, lay))
        {
            anim.SetBool("Fire", true);
        }
    }
}
