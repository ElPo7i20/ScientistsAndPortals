using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private float maxTime;
    [SerializeField] private GameObject playerSprite;
    private float currentTime;

    private void Awake()
    {
        currentTime = 0;
        gameObject.GetComponent<PlayerInput>().enabled = false;
        gameObject.GetComponent<PlayerMovement>().enabled = false;
    }
    private void Update()
    {
        if (currentTime >= maxTime)
        {
            PlayerInPortal();
        }
    }
    private void PlayerInPortal()
    {
        playerSprite.SetActive(true);
    }
}
