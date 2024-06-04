using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource hitAud;
    private float currentHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private Animator animator;
    private bool alive;

    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        animator.SetBool("Hurt", true);
        CheckAlive();
        hitAud.Play();
    }
    private void CheckAlive()
    {
        if (currentHealth < 0)
        {
            animator.SetBool("Die", true);
            SceneManager.LoadScene(2);
        }
    }

}