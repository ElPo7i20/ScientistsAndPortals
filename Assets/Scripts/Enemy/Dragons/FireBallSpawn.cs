using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FireBallSpawn : MonoBehaviour
{
    [SerializeField] private AudioSource shootAud;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject fireBall;
    [SerializeField] private float shootForce;
    private float spawnDirection;
    [SerializeField] private SpriteRenderer spR;

    public void Spawn()
    {
        if (spR.flipX == false)
            spawnDirection = 1;
        if (spR.flipX == true)
            spawnDirection = -1;
        GameObject fireBull = Instantiate(fireBall, firePoint.position, Quaternion.identity);
        Rigidbody2D fireRg = fireBull.GetComponent<Rigidbody2D>();
        fireRg.AddForce(new Vector2(spawnDirection * shootForce, 0), ForceMode2D.Impulse);
        shootAud.Play();
    }
}
