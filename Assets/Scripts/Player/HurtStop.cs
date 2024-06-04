using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtStop : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] PlayerInput input;
    public void NoHurt()
    {
        animator.SetBool("Hurt", false);
        input.enabled = true;
    }
}
