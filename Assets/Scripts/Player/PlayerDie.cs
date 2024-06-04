using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private void DiePlayer()
    {
        Destroy(player);
    }
}
