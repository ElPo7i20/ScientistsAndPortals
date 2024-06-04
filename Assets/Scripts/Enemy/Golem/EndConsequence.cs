using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndConsequence : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public void EndClap()
    {
        gameObject.SetActive(false);
        anim.SetBool("Clap", false);
    }
}
