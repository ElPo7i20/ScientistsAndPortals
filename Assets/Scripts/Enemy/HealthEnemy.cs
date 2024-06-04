using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField] private float healthMax;
    private float healthCount;
    private bool alive;
    [SerializeField] private Animator animEnemy;
    [SerializeField] private SpriteRenderer spREnemy;
    private float timeHit;

    private void Awake()
    {
        timeHit = 0;
        healthCount = healthMax;
    }
    public void TakeDamage(float damage)
    {
        healthCount -= damage;
        spREnemy.color = new Color(0, 0.6f, 1, 1);
        timeHit = 0;
        if (healthCount <= 0)
        {
            animEnemy.SetBool("Die", true);
        }
    }
    private void Update()
    {
        timeHit += Time.deltaTime;
        if (timeHit >= 0.2f)
        {
            spREnemy.color = Color.white;
            timeHit = 0;
        }
    }

}
