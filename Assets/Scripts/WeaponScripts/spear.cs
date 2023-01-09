using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spear : MonoBehaviour
{

    public float atkDamage = 7;
    public float characterDmg;
    public float atkSpeed = 1.5f;
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

void OnDrawGizmosSelected()
{   
    Gizmos.color = Color.red;
    Vector2 attackRange = new Vector2(5.0f, 1.0f);  // set attackRange.x to 2.0 and attackRange.y to 1.0
    Gizmos.DrawWireCube(transform.position, attackRange);
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
}
