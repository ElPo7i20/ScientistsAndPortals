using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DamageEnemy"))
            collision.gameObject.GetComponent<HealthEnemy>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
