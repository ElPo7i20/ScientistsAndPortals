using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("DamagePlayer"))
            collision.gameObject.GetComponent<HealthPlayer>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
