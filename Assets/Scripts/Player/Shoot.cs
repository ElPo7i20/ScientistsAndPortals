using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private AudioSource shootAud;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float firePower;
    [SerializeField] private Transform bulletPosRight;
    [SerializeField] private Transform bulletPosLeft;
    [SerializeField] private Animator anim;
    PlayerInput input;
    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }
    public void Fire(float direction)
    {
        shootAud.Play();
        if(direction == 0)
        {
            anim.SetBool("Fire", true);
        }

        if (input.directionRay == true)
        {

            GameObject currentBullet = Instantiate(bullet, bulletPosRight.position, Quaternion.identity);
            Rigidbody2D currentBulletRb = currentBullet.GetComponent<Rigidbody2D>();
            currentBulletRb.AddForce(new Vector2(1 * firePower, 0), ForceMode2D.Impulse);
        }
        if(input.directionRay == false)
        {
            GameObject currentBullet = Instantiate(bullet, bulletPosLeft.position, Quaternion.identity);
            Rigidbody2D currentBulletRb = currentBullet.GetComponent<Rigidbody2D>();
            currentBulletRb.AddForce(new Vector2(-1 * firePower, 0), ForceMode2D.Impulse);
            currentBullet.transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }
}
