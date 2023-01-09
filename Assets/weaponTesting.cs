using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponTesting : MonoBehaviour
{
    public float atkDamage = 3;
    public float characterDmg;
    public float atkSpeed = 1f;
    float lastAttackTime;
    public float attackRange = 3f;
    public GameObject[] enemies;
    public float totalatk;
    private bool attackMade;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        characterDmg = transform.parent.parent.GetComponent<playerStats>().baseDamage;
        totalatk = characterDmg + atkDamage;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(AttackEnemies(atkSpeed));
        }
    }

    IEnumerator AttackEnemies(float attackSpeed)
    {
        while (true)
        {
            if (Time.time - lastAttackTime > attackSpeed)
            {
                Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                foreach (Collider2D enemy in enemiesInRange)
                {
                    if (enemy.gameObject.CompareTag("Enemy"))
                    {   
                        // dito mo lagay yung attack animation mo
                        yield return new WaitForSeconds(0.5f);
                        enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                        enemy.GetComponent<knockback>().Knockback();
                    }
                }
                lastAttackTime = Time.time;
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }


}

