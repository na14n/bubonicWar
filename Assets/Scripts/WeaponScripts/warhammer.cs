using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warhammer : MonoBehaviour
{
    public int atkDamage = 7;
    public int characterDmg;
    public float atkSpeed = 1f;
    float lastAttackTime;
    public float attackRange = 2f;
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

    void OnTriggerStay2D(Collider2D collider)
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
