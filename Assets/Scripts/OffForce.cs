using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OffForce : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("DamagePlayer"))
        {
            collision.gameObject.GetComponent<PlayerInput>().powerEnable = false;
        }    
    }
}
