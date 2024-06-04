using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    private int countHearts;

    private void Awake()
    {
         countHearts = hearts.Length + 1;
    }
    private void HeartMinus()
    {
        countHearts --;
        hearts[countHearts].SetActive(false);
    }
}
