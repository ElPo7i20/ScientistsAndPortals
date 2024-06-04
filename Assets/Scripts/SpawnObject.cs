using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("DamagePlayer"))
        {
            spawnObject.SetActive(true);
            collision.gameObject.GetComponent<PlayerInput>().enabled = false;
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            anim.SetFloat("Velocity", 0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
