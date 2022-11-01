using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int MaxHealth = 100;
    [SerializeField] int currentHealth;
    [SerializeField] HealthBar healthBar;

    void Start() 
    {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }
    void AttackPlayer(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("You died!");
        Destroy(gameObject, 0);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer(20);
        }
    }
}
