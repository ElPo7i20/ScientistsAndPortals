using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningOff : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Animator animEnemy = collision.gameObject.GetComponent<Animator>();
        animEnemy.SetBool("DieFromPower", true);
        Destroy(gameObject);
    }
}
