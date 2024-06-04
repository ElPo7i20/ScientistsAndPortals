using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPower : MonoBehaviour
{
    [SerializeField] private AudioSource forceAud;
    [SerializeField] private Animator animPlayer;
    [SerializeField] GameObject lightning;
    PlayerInput input;
    [SerializeField] LayerMask lay;
    private Vector3 transformEnemy;
    private void Awake()
    {
        input = GetComponent<PlayerInput>();
    }
    public void UsePower(float distanceRay)
    {
        forceAud.Play();
        GameObject lightningStrike;
        RaycastHit2D[] hit;
        if (input.directionRay == true)
        {
            hit = Physics2D.RaycastAll(transform.position, Vector2.right, distanceRay, lay);
            foreach (RaycastHit2D hits in hit)
            {
                Debug.Log(hits.transform.position);
                transformEnemy = hits.transform.position;
                lightningStrike = Instantiate(lightning, transformEnemy, Quaternion.identity);

            }
        }
        if(input.directionRay == false)
        {
            hit = Physics2D.RaycastAll(transform.position, Vector2.left, distanceRay);
            foreach (RaycastHit2D hits in hit)
            {
                Debug.Log(hits.transform.position);
                transformEnemy = hits.transform.position;
                lightningStrike = Instantiate(lightning, transformEnemy, Quaternion.identity);
            }
        }
        input.enabled = false;
        animPlayer.SetBool("Power", true);
    }
}
