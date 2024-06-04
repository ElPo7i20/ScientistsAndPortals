using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClap : MonoBehaviour
{
    [SerializeField] private Animator animG;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("DamagePlayer"))
        {
            animG.SetBool("Clap", true);
        }
    }
}
