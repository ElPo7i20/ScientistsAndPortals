using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] private float maxTime, damage;
    private float currentTimeInZone;
    private void Awake()
    {
        currentTimeInZone = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DamagePlayer"))
        {
            currentTimeInZone += Time.deltaTime;
            if (currentTimeInZone >= maxTime)
            {
                collision.gameObject.GetComponent<HealthPlayer>().TakeDamage(damage);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        currentTimeInZone = 0;
    }
}
