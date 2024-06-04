using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontShootDragon : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void NotShoot()
    {
        anim.SetBool("Fire", false);
    }
}
