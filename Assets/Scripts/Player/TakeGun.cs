using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGun : MonoBehaviour
{
    [SerializeField] private AudioSource audSrc;
    [SerializeField] private Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DamagePlayer"))
        {
            collision.gameObject.GetComponent<PlayerInput>().haveGun = true;
            collision.gameObject.GetComponent<PlayerInput>().enabled = false;
            anim.SetFloat("Velocity", 0);
            anim.SetBool("TakeGun", true);
            audSrc.Play();
            Destroy(gameObject);
        }
    }

}
