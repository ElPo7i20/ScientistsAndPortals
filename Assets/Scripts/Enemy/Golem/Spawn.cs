using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Animator animG;
    [SerializeField] private float rad;
    [SerializeField] private GameObject clapZone;
    [SerializeField] private LayerMask lay;
    [SerializeField] private Follow fol;
    [SerializeField] private HealthEnemy hE;
    private void Update()
    {
        if(Physics2D.OverlapCircle(transform.position,rad, lay))
        {
            animG.SetBool("Spawn", true);
            clapZone.SetActive(true);
        }
    }
}
