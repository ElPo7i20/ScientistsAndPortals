using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapPower : MonoBehaviour
{
    [SerializeField] private GameObject consOfClap;
    public void AppearanceCons()
    {
        consOfClap.SetActive(true);
    }
}
