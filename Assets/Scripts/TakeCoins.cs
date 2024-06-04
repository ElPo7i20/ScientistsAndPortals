using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class TakeCoins : MonoBehaviour
{
    [SerializeField] private AudioSource audSrc;
    [SerializeField] Points points;
    [SerializeField] private Text pointsScore;
    private int coins;
    private void Awake()
    {
        coins = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DamagePlayer"))
        {
            coins++;
            points.PointsScoreLevel(coins);
            audSrc.Play();
            Destroy(gameObject);
        }
    }
}
