using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damagePlayer;
    [SerializeField] private Transform transformEnemy;
    [SerializeField] private float powerExplosion;
    [SerializeField] private Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DamagePlayer"))
        {
            anim.SetBool("Hit", true);
            collision.gameObject.GetComponent<HealthPlayer>().TakeDamage(damagePlayer);
            Vector2 direction = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<PlayerInput>().enabled = false;
            collision.rigidbody.AddForce(direction.normalized * powerExplosion, ForceMode2D.Impulse);
        }
    }
}
