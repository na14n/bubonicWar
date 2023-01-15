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
    private bool isAttacking = false;

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
        if (Time.time - lastAttackTime > atkSpeed && !isAttacking)
        {

            if (collider.gameObject.CompareTag("Enemy"))
            {
                isAttacking = true;
                StartCoroutine(AttackEnemies());
                Debug.Log("start");
            }
        }
    }

    IEnumerator AttackEnemies()
    {
    while (true)  // This will cause the coroutine to loop indefinitely
    {
        // Wait for the desired amount of time
        yield return new WaitForSeconds(atkSpeed);  // atkSpeed is the interval between attacks

        // Deal the damage
        Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
        foreach (Collider2D enemy in enemiesInRange)
        {
            if (enemy.gameObject.CompareTag("Enemy"))
            {   
                
                yield return new WaitForSeconds(0.5f);
                enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                enemy.GetComponent<knockback>().Knockback(this.transform.position);
            }
        }
    }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }


}

