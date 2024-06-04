using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPatrol : MonoBehaviour
{
    [SerializeField] Follow fol;
    [SerializeField] HealthEnemy hE;

    private void Awake()
    {
        fol.enabled = false;
        hE.enabled = false;
    }
    private void GoPatrol()
    {
        fol.enabled = true;
        hE.enabled = true;
    }
}
