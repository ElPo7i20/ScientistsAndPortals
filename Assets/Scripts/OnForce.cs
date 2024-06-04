using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnForce : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DamagePlayer"))
        {
            collision.gameObject.GetComponent<PlayerInput>().powerEnable = true;
        }
    }
}
