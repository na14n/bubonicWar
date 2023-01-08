using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaScript : MonoBehaviour
{
    public int atkDamage = 5;
    public int characterDmg;
    public float atkSpeed = 0.5f;
    float lastAttackTime;
    public float attackRange = 3f;
    public GameObject[] enemies;
    public int totalatk;
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

// void OnTriggerEnter2D(Collider2D collider)
// {   
//     if (Time.time - lastAttackTime > atkSpeed)
//     {
//         if (collider.gameObject.CompareTag("Enemy"))
//         {
//             Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
//             foreach (Collider2D enemy in enemiesInRange)
//             {
//                 if (enemy.gameObject.CompareTag("Enemy"))
//                 {
//                     enemy.GetComponent<health>().damage(atkDamage + characterDmg, true);
//                 }
//             }
//             lastAttackTime = Time.time;
//         }
//     }
// }


void OnDrawGizmosSelected()
{
    Gizmos.color = Color.red;
    Gizmos.DrawWireCube(transform.position, new Vector3(attackRange, attackRange, 0));
}

    void OnTriggerStay2D(Collider2D collider)
    {
        if (!attackMade)
        {
            if (Time.time - lastAttackTime > atkSpeed)
            {
                if (collider.gameObject.CompareTag("Enemy"))
                {
                    Collider2D[] enemiesInRange = Physics2D.OverlapCircleAll(transform.position, attackRange);
                    foreach (Collider2D enemy in enemiesInRange)
                    {
                        if (enemy.gameObject.CompareTag("Enemy"))
                        {
                            enemy.GetComponent<health>().damage(atkDamage + characterDmg, false);
                        }
                    }
                    attackMade = true;
                    lastAttackTime = Time.time;
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        attackMade = false;
    }

}