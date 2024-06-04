using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputOn : MonoBehaviour
{
    [SerializeField] PlayerInput input;
    [SerializeField] private Animator anim;
    [SerializeField] private AnimatorOverrideController runWithG;
    private void InputEnableTrue()
    {
        input.enabled = true;
        anim.SetBool("TakeGun", false);
        anim.runtimeAnimatorController = runWithG;
    }
    private void PowerOff()
    {
        anim.SetBool("Power", false);
        input.enabled = true;
    }
    private void FireOff()
    {
        anim.SetBool("Fire", false);
    }
}
