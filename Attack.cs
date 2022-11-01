using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform attackPoint;
    [SerializeField] float attackRange = 0.5f;
    [SerializeField] LayerMask enemyLayers;
    [SerializeField] int attackDamage = 40;
    [SerializeField] float dano = 1f;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer();
        }
    }
    void AttackPlayer()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected() 
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "swordWood")
        {
            dano += 7;
            Destroy(other.gameObject, 0);
            Debug.Log("+7 de ataque");
        }
    }
}

