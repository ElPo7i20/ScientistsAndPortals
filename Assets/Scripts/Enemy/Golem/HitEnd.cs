using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnd : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void End()
    {
        anim.SetBool("Hit", true);
    }
}
