using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoManInTheEnd : MonoBehaviour
{
    [SerializeField] private GameObject spawnEnemies;
    [SerializeField] private PlayerInput input;
    [SerializeField] private PlayerMovement move;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (spawnEnemies == true)
        {
            input.enabled = true;
            move.enabled = true;
        }
    }
}
